using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace FFmpeg.NET.Interop
{
    internal sealed class LibrariesLoader : IDisposable
    {
        public const string AV_UTIL = "avutil";
        public const string SW_SCALE = "swscale";
        public const string POSTPROC = "postproc";
        public const string SW_RESAMPLE = "swresample";
        public const string AV_CODEC = "avcodec";
        public const string AV_FORMAT = "avformat";
        public const string AV_FILTER = "avfilter";
        public const string AV_DEVICE = "avdevice";
        private const string DLL_DIR = "lib";

        public static readonly int EAGAIN = OperatingSystem.IsMacOS() ? 35 : 11;

        /// <summary>OS PlatformID.</summary>
        public static readonly PlatformID OSPlatformID = OperatingSystem.IsWindows() ? PlatformID.Win32NT : OperatingSystem.IsLinux() ? PlatformID.Unix : OperatingSystem.IsMacOS() ? PlatformID.MacOSX : PlatformID.Other;

        /// <summary>OS Platform Architecture (linux-x64,linux-x86,linux-arm64,linux-arm,win-x64,win-x86,win-arm64,win-arm,macos)./// </summary>
        public static readonly string OsPlatformArch = (OperatingSystem.IsWindows() ? "win" : OperatingSystem.IsLinux() ? "linux" : OperatingSystem.IsMacOS() ? "macos" : "other") + RuntimeInformation.OSArchitecture switch
        {
            Architecture.X64 => "-x64",
            Architecture.X86 => "-x86",
            Architecture.Arm64 => "-arm64",
            Architecture.Arm => "-arm",
            _ => string.Empty
        };

        internal static readonly string DIR = Path.Combine(DLL_DIR, OsPlatformArch);

        /// <summary>
        /// dynamic link library dependency relationes.
        /// </summary>
        public static readonly IDictionary<string, string[]> DEPENDENCIES = new Dictionary<string, string[]>(StringComparer.CurrentCulture)
        {
            { AV_UTIL, new string[]{} },
            { SW_SCALE, new []{ AV_UTIL } },
            { POSTPROC, new []{ AV_UTIL } },
            { SW_RESAMPLE, new []{ AV_UTIL } },
            { AV_CODEC, new []{ AV_UTIL, SW_RESAMPLE } },
            { AV_FORMAT, new []{ AV_UTIL, SW_RESAMPLE, AV_CODEC } },
            { AV_FILTER, new []{ AV_UTIL, SW_SCALE, POSTPROC, SW_RESAMPLE, AV_CODEC, AV_FORMAT } },
            { AV_DEVICE, new []{ AV_UTIL, SW_SCALE, POSTPROC, SW_RESAMPLE, AV_CODEC, AV_FORMAT, AV_FILTER } },
        };

        public static readonly IDictionary<string, int> VERSIONS = new Dictionary<string, int>(StringComparer.CurrentCulture)
        {
            { AV_UTIL, 57 },
            { SW_SCALE, 6 },
            { POSTPROC, 56 },
            { SW_RESAMPLE, 4 },
            { AV_CODEC, 59 },
            { AV_FORMAT, 59 },
            { AV_FILTER, 8 },
            { AV_DEVICE, 59 },
        };

        private readonly Dictionary<string, IntPtr> Loadeds = new Dictionary<string, IntPtr>(StringComparer.CurrentCulture);

        /// <summary>
        /// dynamic link libraries path
        /// </summary>
        private string _DIR;

        public LibrariesLoader(FFmpegSettings settings)
        {
            _DIR = string.IsNullOrEmpty(settings.DLLDIR) ? DIR : settings.DLLDIR;
        }

        private IntPtr Load(string library)
        {
            IntPtr handle;

            if (Loadeds.TryGetValue(library, out handle)) return handle;

            int version = VERSIONS[library];

            // load internal libraries
            if (NativeLibrary.TryLoad(PATH(library, version, true), typeof(LibrariesLoader).Assembly, DllImportSearchPath.AssemblyDirectory, out handle))
            {
                Loadeds.Add(library, handle);
                return handle;
            }
            if (NativeLibrary.TryLoad(PATH(library, use: true), typeof(LibrariesLoader).Assembly, DllImportSearchPath.AssemblyDirectory, out handle))
            {
                Loadeds.Add(library, handle);
                return handle;
            }

            // frist load external libraries. 
            if (NativeLibrary.TryLoad(PATH(library, version), typeof(LibrariesLoader).Assembly, DllImportSearchPath.UseDllDirectoryForDependencies, out handle))
            {
                Loadeds.Add(library, handle);
                return handle;
            }
            if (NativeLibrary.TryLoad(PATH(library), typeof(LibrariesLoader).Assembly, DllImportSearchPath.UseDllDirectoryForDependencies, out handle))
            {
                Loadeds.Add(library, handle);
                return handle;
            }

            throw new DllNotFoundException($"library '{library}' not found.");
        }

        public IntPtr GetPtr(string library)
        {
            if (string.IsNullOrEmpty(library)) throw new ArgumentNullException(nameof(library));
            if (!DEPENDENCIES.TryGetValue(library, out var dependencies)) throw new ArgumentException("please input an corrent library name.", nameof(library));
            if (Loadeds.TryGetValue(library, out var handle)) return handle;
            foreach (var dependency in dependencies)
            {
                Load(dependency);
            }
            return Load(library);
        }


        private string PATH(string name, int? version = null, bool use = false)
        => use ? Path.Combine(_DIR, GetLibraryName(name, version)) : GetLibraryName(name, version);


        public static string GetLibraryName(string library, int? version) => OSPlatformID switch
        {
            PlatformID.Win32NT => version.HasValue ? $"{library}-{version}.dll" : $"{library}.dll",
            PlatformID.Unix => version.HasValue ? $"lib{library}.so.{version}" : $"lib{library}.so",
            PlatformID.MacOSX => version.HasValue ? $"lib{library}.{version}.dylib" : $"lib{library}.dylib",
            _ => throw new PlatformNotSupportedException()
        };

        public void Dispose()
        {
            foreach (var handle in Loadeds.Values)
            {
                NativeLibrary.Free(handle);
            }
        }

    }
}
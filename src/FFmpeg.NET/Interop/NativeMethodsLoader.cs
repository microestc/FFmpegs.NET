using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace FFmpeg.NET.Interop
{
    internal static class NativeMethodsLoader
    {
        public static string AVUTIL => LibraryNames.AVUTIL;
        public static string SWSCALE => LibraryNames.SWSCALE;
        public static string POSTPROC => LibraryNames.POSTPROC;
        public static string SWRESAMPLE => LibraryNames.SWRESAMPLE;
        public static string AVCODEC => LibraryNames.AVCODEC;
        public static string AVFORMAT => LibraryNames.AVFORMAT;
        public static string AVFILTER => LibraryNames.AVFILTER;
        public static string AV_DEVICE => LibraryNames.AVDEVICE;
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

        /// <summary>
        /// dynamic link libraries path
        /// </summary>
        private static string DIR = Path.Combine(DLL_DIR, OsPlatformArch);

        /// <summary>
        /// dynamic link libraries path changed.
        /// </summary>
        private static bool Changed => FFmpeg.DIR != null && FFmpeg.DIR != DIR ? (DIR = FFmpeg.DIR) == DIR : false;

        /// <summary>
        /// dynamic link library dependency relationes.
        /// </summary>
        public static readonly IDictionary<string, string[]> DEPENDENCIES = new Dictionary<string, string[]>(StringComparer.CurrentCulture)
        {
            { AVUTIL, new string[]{} },
            { SWSCALE, new []{ AVUTIL } },
            { POSTPROC, new []{ AVUTIL } },
            { SWRESAMPLE, new []{ AVUTIL } },
            { AVCODEC, new []{ AVUTIL, SWRESAMPLE } },
            { AVFORMAT, new []{ AVUTIL, SWRESAMPLE, AVCODEC } },
            { AVFILTER, new []{ AVUTIL, SWSCALE, POSTPROC, SWRESAMPLE, AVCODEC, AVFORMAT } },
            { AV_DEVICE, new []{ AVUTIL, SWSCALE, POSTPROC, SWRESAMPLE, AVCODEC, AVFORMAT, AVFILTER } },
        };

        public static readonly IDictionary<string, int> VERSIONS = new Dictionary<string, int>(StringComparer.CurrentCulture)
        {
            { AVUTIL, 57 },
            { SWSCALE, 6 },
            { POSTPROC, 56 },
            { SWRESAMPLE, 4 },
            { AVCODEC, 59 },
            { AVFORMAT, 59 },
            { AVFILTER, 8 },
            { AV_DEVICE, 59 },
        };

        private readonly static Dictionary<string, IntPtr> Loadeds = new Dictionary<string, IntPtr>(StringComparer.CurrentCulture);

        private static IntPtr Load(string library)
        {
            if (Changed && Loadeds.Count > 0)
            {
                Loadeds.Values.ToList().ForEach(ptr => NativeLibrary.Free(ptr));
                Loadeds.Clear();
            }

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

        public static IntPtr GetPtr(string library)
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

        private static string PATH(string name, int? version = null, bool use = false)
        => use ? Path.Combine(DIR, GetLibraryName(name, version)) : GetLibraryName(name, version);

        public static string GetLibraryName(string library, int? version) => OSPlatformID switch
        {
            PlatformID.Win32NT => version.HasValue ? $"{library}-{version}.dll" : $"{library}.dll",
            PlatformID.Unix => version.HasValue ? $"lib{library}.so.{version}" : $"lib{library}.so",
            PlatformID.MacOSX => version.HasValue ? $"lib{library}.{version}.dylib" : $"lib{library}.dylib",
            _ => throw new PlatformNotSupportedException()
        };
    }
}
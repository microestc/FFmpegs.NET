using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace FFmpeg.NET.Interop
{
    internal static class InteropLoader
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

        private static string DIR = Path.Combine(DLL_DIR, OsPlatformArch);

        /// <summary>
        /// dynamic link libraries path
        /// </summary>
        public static string CurrentDIR = DIR;

        /// <summary>
        /// dynamic link library dependency relationes.
        /// </summary>
        private static readonly IDictionary<string, string[]> DEPENDENCIES = new Dictionary<string, string[]>(StringComparer.CurrentCulture)
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

        private readonly static IDictionary<string, IntPtr> LoadedHandles = new Dictionary<string, IntPtr>(StringComparer.CurrentCulture);

        private readonly static IDictionary<string, IntPtr> LoadedMethodHandles = new Dictionary<string, IntPtr>(StringComparer.CurrentCulture);

        private static void Dispose()
        {
            if (LoadedMethodHandles.Count > 0)
            {
                // LoadedMethodHandles.Values.ToList().ForEach(ptr => Marshal.FreeCoTaskMem(ptr));
                LoadedMethodHandles.Clear();
            }
            if (LoadedHandles.Count > 0)
            {
                LoadedHandles.Values.ToList().ForEach(ptr => NativeLibrary.Free(ptr));
                LoadedHandles.Clear();
            }
        }

        static InteropLoader()
        {
            AppDomain.CurrentDomain.ProcessExit += (s, e) => Dispose();
        }

        /// <summary>
        /// dynamic link libraries path changed.
        /// </summary>
        private static bool HasChanged => FFmpegapi.DLLDIR != null && FFmpegapi.DLLDIR != CurrentDIR ? (CurrentDIR = FFmpegapi.DLLDIR) == CurrentDIR : false;

        private static IntPtr Load(string library)
        {
            IntPtr handle;
            if (LoadedHandles.TryGetValue(library, out handle)) return handle;

            int version = VERSIONS[library];

            // load internal libraries
            if (NativeLibrary.TryLoad(PATH(library, version, true), typeof(InteropLoader).Assembly, DllImportSearchPath.AssemblyDirectory, out handle))
            {
                LoadedHandles.Add(library, handle);
                return handle;
            }
            if (NativeLibrary.TryLoad(PATH(library, use: true), typeof(InteropLoader).Assembly, DllImportSearchPath.AssemblyDirectory, out handle))
            {
                LoadedHandles.Add(library, handle);
                return handle;
            }

            // frist load external libraries. 
            if (NativeLibrary.TryLoad(PATH(library, version), typeof(InteropLoader).Assembly, DllImportSearchPath.UseDllDirectoryForDependencies, out handle))
            {
                LoadedHandles.Add(library, handle);
                return handle;
            }
            if (NativeLibrary.TryLoad(PATH(library), typeof(InteropLoader).Assembly, DllImportSearchPath.UseDllDirectoryForDependencies, out handle))
            {
                LoadedHandles.Add(library, handle);
                return handle;
            }
            throw new DllNotFoundException(Strings.DllNotFound(library));
        }

        private static IntPtr GetLibraryPtr(string library)
        {
            if (string.IsNullOrEmpty(library)) throw new ArgumentNullException(nameof(library));
            if (!DEPENDENCIES.TryGetValue(library, out var dependencies)) throw new ArgumentException(Strings.LibraryNameInvalid(library), nameof(library));
            if (LoadedHandles.TryGetValue(library, out var handle)) return handle;
            foreach (var dependency in dependencies)
            {
                Load(dependency);
            }
            return Load(library);
        }

        public static IntPtr NativeMethodPtr(string library, string method)
        {
            if (string.IsNullOrEmpty(library)) throw new ArgumentNullException(nameof(library));
            if (string.IsNullOrEmpty(method)) throw new ArgumentNullException(nameof(method));
            if (HasChanged) Dispose();
            var key = $"{library}_{method}";
            if (LoadedMethodHandles.TryGetValue(key, out IntPtr ret)) return ret;
            var handle = GetLibraryPtr(library);
            if (NativeLibrary.TryGetExport(handle, method, out IntPtr address))
            {
                LoadedMethodHandles.Add(key, address);
                return address;
            }
            return IntPtr.Zero;
        }

        private static string PATH(string name, int? version = null, bool use = false)
        => use ? Path.Combine(CurrentDIR, GetLibraryName(name, version)) : GetLibraryName(name, version);

        private static string GetLibraryName(string library, int? version) => OSPlatformID switch
        {
            PlatformID.Win32NT => version.HasValue ? $"{library}-{version}.dll" : $"{library}.dll",
            PlatformID.Unix => version.HasValue ? $"lib{library}.so.{version}" : $"lib{library}.so",
            PlatformID.MacOSX => version.HasValue ? $"lib{library}.{version}.dylib" : $"lib{library}.dylib",
            _ => throw new PlatformNotSupportedException()
        };
    }
}
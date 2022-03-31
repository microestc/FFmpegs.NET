using System.Runtime.InteropServices;

namespace FFmpeg.NET.Interop
{
    internal sealed class Libraries
    {
        public const string AV_UTIL = "avutil";
        public const string SW_SCALE = "swscale";
        public const string POSTPROC = "postproc";
        public const string SW_RESAMPLE = "swresample";
        public const string AV_CODEC = "avcodec";
        public const string AV_FORMAT = "avformat";
        public const string AV_FILTER = "avfilter";
        public const string AV_DEVICE = "avdevice";

        internal const string DLLS_DIR = "lib";

        // 动态库依赖关系
        public static readonly IDictionary<string, string[]> LibraryDependencies = new Dictionary<string, string[]>(StringComparer.CurrentCulture)
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

        public static readonly IDictionary<string, int> LIBRARYVERSION_MAPS = new Dictionary<string, int>(StringComparer.CurrentCulture)
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

        public static Dictionary<string, IntPtr> LoadedLibraries = new Dictionary<string, IntPtr>(StringComparer.CurrentCulture);

        /// <summary>
        /// OS PlatformID
        /// </summary>
        public static PlatformID OSPlatformID = OperatingSystem.IsWindows() ? PlatformID.Win32NT : OperatingSystem.IsLinux() ? PlatformID.Unix : OperatingSystem.IsMacOS() ? PlatformID.MacOSX : PlatformID.Other;

        /// <summary>
        /// OS 架构 (linux-x64,linux-x86,linux-arm64,linux-arm,win-x64,win-x86,win-arm64,win-arm,macos)
        /// </summary>
        public static string OsPlatform = (OperatingSystem.IsWindows() ? "win" : OperatingSystem.IsLinux() ? "linux" : OperatingSystem.IsMacOS() ? "macos" : "other") + RuntimeInformation.OSArchitecture switch
        {
            Architecture.X64 => "-x64",
            Architecture.X86 => "-x86",
            Architecture.Arm64 => "-arm64",
            Architecture.Arm => "-arm",
            _ => string.Empty
        };


        public Libraries()
        {
            foreach (var row in LIBRARYVERSION_MAPS)
            {
                IntPtr handle;
                // frist load external libraries. 
                if (NativeLibrary.TryLoad(PlatformLibraryPath(row.Key, row.Value), typeof(Libraries).Assembly, DllImportSearchPath.UseDllDirectoryForDependencies, out handle))
                {
                    LoadedLibraries.Add(row.Key, handle);
                    continue;
                }
                if (NativeLibrary.TryLoad(PlatformLibraryPath(row.Key), typeof(Libraries).Assembly, DllImportSearchPath.UseDllDirectoryForDependencies, out handle))
                {
                    LoadedLibraries.Add(row.Key, handle);
                    continue;
                }
                // load internal libraries
                if (NativeLibrary.TryLoad(PlatformLibraryPath(row.Key, row.Value, true), typeof(Libraries).Assembly, DllImportSearchPath.AssemblyDirectory, out handle))
                {
                    LoadedLibraries.Add(row.Key, handle);
                    continue;
                }
                if (NativeLibrary.TryLoad(PlatformLibraryPath(row.Key, @internal: true), typeof(Libraries).Assembly, DllImportSearchPath.AssemblyDirectory, out handle))
                {
                    LoadedLibraries.Add(row.Key, handle);
                    continue;
                }
                throw new DllNotFoundException($"Not found dynamic library '{row.Key}'.");
            }
        }


        /// <summary>
        /// 通过动态库名称构建不同平台下可加载动态库路径
        /// </summary>
        /// <param name="libraryName">动态库名称</param>
        /// <param name="version">动态库后缀版本号</param>
        /// <param name="internal">是否使用内部动态库</param>
        /// <returns></returns>
        public static string PlatformLibraryPath(string libraryName, int? version = null, bool @internal = false)
        {
            if (string.IsNullOrEmpty(libraryName)) throw new ArgumentNullException(nameof(libraryName));
            if (@internal)
            {
                if (version.HasValue)
                {
                    return OSPlatformID switch
                    {
                        PlatformID.Win32NT => Path.Combine(DLLS_DIR, OsPlatform, $"{libraryName}-{version}.dll"),
                        PlatformID.Unix => Path.Combine(DLLS_DIR, OsPlatform, $"lib{libraryName}.so.{version}"),
                        PlatformID.MacOSX => Path.Combine(DLLS_DIR, OsPlatform, $"lib{libraryName}.{version}.dylib"),
                        _ => throw new PlatformNotSupportedException()
                    };
                }
                else
                {
                    return OSPlatformID switch
                    {
                        PlatformID.Win32NT => Path.Combine(DLLS_DIR, OsPlatform, $"{libraryName}.dll"),
                        PlatformID.Unix => Path.Combine(DLLS_DIR, OsPlatform, $"lib{libraryName}.so"),
                        PlatformID.MacOSX => Path.Combine(DLLS_DIR, OsPlatform, $"lib{libraryName}.dylib"),
                        _ => throw new PlatformNotSupportedException()
                    };
                }
            }
            else
            {
                if (version.HasValue)
                {
                    return OSPlatformID switch
                    {
                        PlatformID.Win32NT => $"{libraryName}-{version}.dll",
                        PlatformID.Unix => $"lib{libraryName}.so.{version}",
                        PlatformID.MacOSX => $"lib{libraryName}.{version}.dylib",
                        _ => throw new PlatformNotSupportedException()
                    };
                }
                else
                {
                    return OSPlatformID switch
                    {
                        PlatformID.Win32NT => $"{libraryName}.dll",
                        PlatformID.Unix => $"lib{libraryName}.so",
                        PlatformID.MacOSX => $"lib{libraryName}.dylib",
                        _ => throw new PlatformNotSupportedException()
                    };
                }
            }
        }



    }
}
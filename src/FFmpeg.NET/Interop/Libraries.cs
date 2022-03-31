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

        internal static string DLL_DIR = "lib";

        // 动态库依赖关系
        // public static readonly IDictionary<string, string[]> LibraryDependencies = new Dictionary<string, string[]>(StringComparer.CurrentCulture)
        // {
        //     { AV_UTIL, new string[]{} },
        //     { SW_SCALE, new []{ AV_UTIL } },
        //     { POSTPROC, new []{ AV_UTIL } },
        //     { SW_RESAMPLE, new []{ AV_UTIL } },
        //     { AV_CODEC, new []{ AV_UTIL, SW_RESAMPLE } },
        //     { AV_FORMAT, new []{ AV_UTIL, SW_RESAMPLE, AV_CODEC } },
        //     { AV_FILTER, new []{ AV_UTIL, SW_SCALE, POSTPROC, SW_RESAMPLE, AV_CODEC, AV_FORMAT } },
        //     { AV_DEVICE, new []{ AV_UTIL, SW_SCALE, POSTPROC, SW_RESAMPLE, AV_CODEC, AV_FORMAT, AV_FILTER } },
        // };

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

        private static readonly Dictionary<string, IntPtr> LoadedLibraries = new Dictionary<string, IntPtr>(StringComparer.CurrentCulture);

        /// <summary>
        /// OS PlatformID
        /// </summary>
        public static readonly PlatformID OSPlatformID = OperatingSystem.IsWindows() ? PlatformID.Win32NT : OperatingSystem.IsLinux() ? PlatformID.Unix : OperatingSystem.IsMacOS() ? PlatformID.MacOSX : PlatformID.Other;

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

        // 已创建动态库实例
        public static readonly Libraries Instance = new Libraries();

        private bool _supported = false;

        private IList<string> _errors = new List<string>();

        /// <summary>
        /// 动态库是否全部加载
        /// </summary>
        public bool IsSupported => _supported;

        public IList<string> Errors => _errors;

        public IntPtr PTR_AVUTIL { get; private set; }
        public IntPtr PTR_SWSCALE { get; private set; }
        public IntPtr PTR_POSTPROC { get; private set; }
        public IntPtr PTR_SWRESAMPLE { get; private set; }
        public IntPtr PTR_AVCODEC { get; private set; }
        public IntPtr PTR_AVFORMAT { get; private set; }
        public IntPtr PTR_AVFILTER { get; private set; }
        public IntPtr PTR_AVDEVICE { get; private set; }

        public Libraries()
        {
            Load();
        }

        private void Load()
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
                _errors.Add($"Not found dynamic library '{row.Key}'.");
            }
            _supported = _errors.Count == 0;
            if (IsSupported)
            {
                PTR_AVUTIL = LoadedLibraries.GetValueOrDefault(AV_UTIL);
                PTR_SWSCALE = LoadedLibraries.GetValueOrDefault(SW_SCALE);
                PTR_POSTPROC = LoadedLibraries.GetValueOrDefault(POSTPROC);
                PTR_SWRESAMPLE = LoadedLibraries.GetValueOrDefault(SW_RESAMPLE);
                PTR_AVCODEC = LoadedLibraries.GetValueOrDefault(AV_CODEC);
                PTR_AVFORMAT = LoadedLibraries.GetValueOrDefault(AV_FORMAT);
                PTR_AVFILTER = LoadedLibraries.GetValueOrDefault(AV_FILTER);
                PTR_AVDEVICE = LoadedLibraries.GetValueOrDefault(AV_DEVICE);
            }
            else
            {
                foreach (var lib in LoadedLibraries)
                {
                    NativeLibrary.Free(lib.Value);
                    LoadedLibraries.Remove(lib.Key);
                }
            }
        }

        private void Clear()
        {
            _errors.Clear();
            _supported = false;
            foreach (var lib in LoadedLibraries)
            {
                NativeLibrary.Free(lib.Value);
                LoadedLibraries.Remove(lib.Key);
            }
        }

        public void Reload(string? dir = null)
        {
            if (!string.IsNullOrEmpty(dir)) DLL_DIR = dir;
            Clear();
            Load();
        }

        /// <summary>
        /// 通过动态库名称构建不同平台下可加载动态库路径
        /// </summary>
        /// <param name="libraryName">动态库名称</param>
        /// <param name="version">动态库后缀版本号</param>
        /// <param name="internal">是否使用内部动态库</param>
        /// <returns></returns>
        private static string PlatformLibraryPath(string libraryName, int? version = null, bool @internal = false)
        {
            if (string.IsNullOrEmpty(libraryName)) throw new ArgumentNullException(nameof(libraryName));
            if (@internal)
            {
                if (version.HasValue)
                {
                    return OSPlatformID switch
                    {
                        PlatformID.Win32NT => Path.Combine(DLL_DIR, OsPlatform, $"{libraryName}-{version}.dll"),
                        PlatformID.Unix => Path.Combine(DLL_DIR, OsPlatform, $"lib{libraryName}.so.{version}"),
                        PlatformID.MacOSX => Path.Combine(DLL_DIR, OsPlatform, $"lib{libraryName}.{version}.dylib"),
                        _ => throw new PlatformNotSupportedException()
                    };
                }
                else
                {
                    return OSPlatformID switch
                    {
                        PlatformID.Win32NT => Path.Combine(DLL_DIR, OsPlatform, $"{libraryName}.dll"),
                        PlatformID.Unix => Path.Combine(DLL_DIR, OsPlatform, $"lib{libraryName}.so"),
                        PlatformID.MacOSX => Path.Combine(DLL_DIR, OsPlatform, $"lib{libraryName}.dylib"),
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
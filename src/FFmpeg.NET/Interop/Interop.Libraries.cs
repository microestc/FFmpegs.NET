using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace FFmpeg.NET.Interop
{
    internal sealed class Libraries
    {
        public const string Libdl = "libdl";

        public const string Libavcodec = "avcodec";

        public const string Libavdevice = "avdevice";

        public const string Libavfilter = "avfilter";

        public const string Libavformat = "avformat";

        public const string Libavutil = "avutil";

        public const string Libpostproc = "postproc";

        public const string Libswscale = "swscale";

        public const string Libswresample = "swresample";

        public static Func<string, string> OSPlatformLibrary { get; set; }

        public static readonly IDictionary<string, string[]> Dependencies = new Dictionary<string, string[]>(StringComparer.CurrentCulture)
        {
            { Libavutil, new string[]{} },
            { Libavfilter, new []{ Libavutil } },
            { Libswscale, new []{ Libavutil } },
            { Libpostproc, new []{ Libavutil } },
            { Libavcodec, new []{ Libavutil } },
            { Libswresample, new []{ Libavutil } },
            { Libavformat, new []{ Libavutil, Libavcodec } },
            { Libavdevice, new []{ Libavutil, Libavcodec, Libavformat } },
        };

        public static readonly IDictionary<string, int> LIBRARY_VERSIONS = new Dictionary<string, int>(StringComparer.CurrentCulture)
        {
            { Libavutil, 0 },
            { Libavfilter, 0 },
            { Libswscale, 0 },
            { Libpostproc, 0 },
            { Libavcodec, 0 },
            { Libswresample, 0 },
            { Libavformat, 0 },
            { Libavdevice, 0 },
        };

        public static Dictionary<string, IntPtr> LoadedLibraries = new Dictionary<string, IntPtr>(StringComparer.CurrentCulture);

        static Libraries()
        {
            OSPlatformLibrary = GetOsPlatformLibraryName;
            foreach (var row in Dependencies)
            {
                var library = OSPlatformLibrary(row.Key);
                var libraryDependencies = row.Value;
                if (libraryDependencies.Any(n => !LoadedLibraries.ContainsKey(n)))
                {
                    foreach (var item in libraryDependencies.Where(n => !LoadedLibraries.ContainsKey(n)))
                    {
                        if (!NativeLibrary.TryLoad(OSPlatformLibrary(item), typeof(Libraries).Assembly, DllImportSearchPath.AssemblyDirectory, out IntPtr handle))
                            throw new DllNotFoundException();
                    }
                }
            }
        }

        public static string GetOsPlatformLibraryName(string libraryName)
        {
            if (!LIBRARY_VERSIONS.TryGetValue(libraryName, out var version)) throw new KeyNotFoundException($"Dynamic libraries Verions Map not found any key '{libraryName}'.");
            if (OperatingSystem.IsWindows()) return $"{libraryName}-{version}.dll";
            if (OperatingSystem.IsLinux()) return $"lib{libraryName}.so.{version}";
            if (OperatingSystem.IsMacOS()) return $"lib{libraryName}.{version}.dylib";
            throw new PlatformNotSupportedException();
        }

    }
}
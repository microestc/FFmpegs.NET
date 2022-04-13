using System.Resources;

namespace FFmpeg.NET
{
    public static class Strings
    {
        private static readonly ResourceManager _resourceManager;
        static Strings()
        {
            _resourceManager = new ResourceManager("FFmpeg.NET.Resources.Strings", typeof(Strings).Assembly);
        }

        private static string GetString(string name, params object[] args)
        {
            var value = _resourceManager.GetString(name)!;
            if (args.Length == 0) return value;
            return string.Format(value, args);
        }

        public static string CurrentPlatformNotsupported => GetString("current_platform_notsupported");

        public static string DllNotFound(string name) => GetString("dll_notfound", name);

        public static string LibraryNameInvalid(string name) => GetString("library_name_invalid", name);
    }
}
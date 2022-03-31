

_ = FFmpeg.Library.Version;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine(typeof(FFmpeg.Library).FullName);

namespace FFmpeg
{
    public class Library
    {

        public int Num = 1;

        public static int Version = GetVersion();

        public static int Loaded = Load();

        public static Library Instance = new Library();


        private static int GetVersion()
        {
            Console.WriteLine("GetVersion");
            return 10;
        }

        public static int Load()
        {
            Console.WriteLine("Load");
            return 2;
        }

        public Library()
        {
            Console.WriteLine("Library");
        }

    }
}
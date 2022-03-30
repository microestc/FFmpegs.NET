using System.Net;
using System.Runtime.InteropServices;

namespace FFmpeg.NET.Interop
{
    internal sealed class NativeApi
    {
        internal static NativeApi Api { get; } = null!;

        static NativeApi()
        {
            
        }
    }
}
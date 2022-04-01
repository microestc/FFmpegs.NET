using System.Runtime.InteropServices;

namespace FFmpeg.NET.Internal
{
    internal static unsafe partial class NativeMethods
    {
        [NativeMethod("av_version_info")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public delegate string GetAvVersionInfoDelegate();

        
    }
}
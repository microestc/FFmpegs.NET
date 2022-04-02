using System.Runtime.InteropServices;

namespace FFmpeg.NET.Internal
{
    public static unsafe partial class NativeMethods
    {
        [NativeMethod("av_version_info")]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(StringPtrMarshaler))]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public delegate string GetVersionInfoDelegate();

    }
}
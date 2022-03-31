using System.Net;
using System.Runtime.InteropServices;
using FFmpeg.NET.Interop;

namespace FFmpeg.NET.Internal
{
    internal unsafe sealed class NativeApi
    {
        internal static NativeApi Api { get; } = new NativeApi();

        internal Libraries Libraries { get; }

        public NativeApi()
        {
            Libraries = Libraries.Instance;

        }

        public static IntPtr FunctionPtr(IntPtr handle, string function) 
            => NativeLibrary.TryGetExport(handle, function, out IntPtr address) ? address : default;
    }
}
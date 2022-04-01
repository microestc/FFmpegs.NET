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


        public static T GetNativeMethodDelegate<T>(IntPtr handle)
        {
            var method = typeof(T).GetCustomAttribute()
            var ptr = NativeLibrary.TryGetExport(handle, function, out IntPtr address) ? address : default;
            return Marshal.GetDelegateForFunctionPointer<T>(ptr);
        }
    }
}
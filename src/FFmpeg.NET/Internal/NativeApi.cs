using System;
using System.Runtime.InteropServices;
using FFmpeg.NET.Interop;
using static FFmpeg.NET.Internal.NativeMethods;

namespace FFmpeg.NET.Internal
{
    public unsafe sealed class NativeApi
    {
        public static NativeApi Api { get; } = new NativeApi();

        internal Libraries LibrariesInstance { get; }

        public NativeApi()
        {
            LibrariesInstance = Libraries.Instance;
            if (!LibrariesInstance.IsSupported) throw new NotSupportedException();
            GetVersionInfo = NativeMethodDelegate<GetVersionInfoDelegate>(LibrariesInstance.PTR_AVUTIL);
        }

        public static T NativeMethodDelegate<T>(IntPtr handle)
        {
            var attribute = (NativeMethodAttribute?)Attribute.GetCustomAttribute(typeof(T), typeof(NativeMethodAttribute));
            if (attribute == null) throw new AttributeNotFoundException(typeof(T), typeof(NativeMethodAttribute));
            var intptr = NativeLibrary.TryGetExport(handle, attribute.Method, out IntPtr address) ? address : default;
            return Marshal.GetDelegateForFunctionPointer<T>(intptr);
        }

        public GetVersionInfoDelegate GetVersionInfo { get; }
    }
}
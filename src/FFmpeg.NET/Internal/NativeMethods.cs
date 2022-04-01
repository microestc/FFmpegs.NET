using System;
using System.Runtime.InteropServices;

namespace FFmpeg.NET.Internal
{
    public static unsafe partial class NativeMethods
    {
        [NativeMethod("av_version_info")]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public delegate string GetVersionInfoDelegate();

        
    }

    internal class ConstCharPtrMarshaler : ICustomMarshaler
    {
        public object MarshalNativeToManaged(IntPtr pNativeData) => Marshal.PtrToStringAnsi(pNativeData)!;

        public IntPtr MarshalManagedToNative(object managedObj) => IntPtr.Zero;

        public void CleanUpNativeData(IntPtr pNativeData)
        {
        }

        public void CleanUpManagedData(object managedObj)
        {
        }

        public int GetNativeDataSize() => IntPtr.Size;

        private static readonly ConstCharPtrMarshaler Instance = new();

        public static ICustomMarshaler GetInstance(string cookie) => Instance;
    }
}
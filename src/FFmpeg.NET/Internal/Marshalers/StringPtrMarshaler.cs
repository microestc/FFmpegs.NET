using System;
using System.Runtime.InteropServices;

namespace FFmpeg.NET.Internal
{
    internal class StringPtrMarshaler : ICustomMarshaler
    {
        private StringPtrMarshaler() { }
        public static ICustomMarshaler Instance = new StringPtrMarshaler();
        public static ICustomMarshaler GetInstance(string cookie) => Instance;
        public void CleanUpManagedData(object ManagedObj)
        {
            if (ManagedObj is IDisposable disposable)
            {
                disposable.Dispose();
            }
        }

        public void CleanUpNativeData(IntPtr pNativeData)
        {
            // Need not free
        }

        public int GetNativeDataSize() => IntPtr.Size;

        public IntPtr MarshalManagedToNative(object ManagedObj)
        {
            if (ManagedObj is string str)
                return Marshal.StringToCoTaskMemAuto(str);
            return IntPtr.Zero;
        }

        public object MarshalNativeToManaged(IntPtr pNativeData)
        {
            if (pNativeData == IntPtr.Zero) return string.Empty;
            return Marshal.PtrToStringAuto(pNativeData)!;
        }
    }
}
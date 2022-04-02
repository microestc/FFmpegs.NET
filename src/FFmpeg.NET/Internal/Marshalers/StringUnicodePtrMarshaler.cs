using System;
using System.Runtime.InteropServices;

namespace FFmpeg.NET.Internal
{
    internal class StringUnicodePtrMarshaler : ICustomMarshaler
    {
        private StringUnicodePtrMarshaler() { }
        public static ICustomMarshaler Instance = new StringUnicodePtrMarshaler();
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
            Marshal.Release(pNativeData);
        }

        public int GetNativeDataSize() => IntPtr.Size;

        public IntPtr MarshalManagedToNative(object ManagedObj)
        {
            if (ManagedObj is string ansiStr)
                return Marshal.StringToCoTaskMemUni(ansiStr);
            return IntPtr.Zero;
        }

        public object MarshalNativeToManaged(IntPtr pNativeData)
        {
            if (pNativeData == IntPtr.Zero) return string.Empty;
            return Marshal.PtrToStringUni(pNativeData)!;
        }
    }
}
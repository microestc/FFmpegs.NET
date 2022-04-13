using System;
using System.Runtime.InteropServices;

namespace FFmpeg.NET.Internal
{
    internal class StringAnsiPtrMarshaler : ICustomMarshaler
    {
        private StringAnsiPtrMarshaler() { }
        public static ICustomMarshaler Instance = new StringAnsiPtrMarshaler();
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
        }

        public int GetNativeDataSize() => IntPtr.Size;

        public IntPtr MarshalManagedToNative(object ManagedObj)
        {
            if (ManagedObj is string ansiStr)
                return Marshal.StringToCoTaskMemAnsi(ansiStr);
            return IntPtr.Zero;
        }

        public object MarshalNativeToManaged(IntPtr pNativeData)
        {
            if (pNativeData == IntPtr.Zero) return string.Empty;
            return Marshal.PtrToStringAnsi(pNativeData)!;
        }
    }
}
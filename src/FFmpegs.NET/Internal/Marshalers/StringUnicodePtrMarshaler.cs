using System;
using System.Runtime.InteropServices;

namespace FFmpegs.NET.Internal
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
        }

        public int GetNativeDataSize() => IntPtr.Size;

        public IntPtr MarshalManagedToNative(object ManagedObj)
        {
            if (ManagedObj is string str)
                return Marshal.StringToCoTaskMemUni(str);
            return IntPtr.Zero;
        }

        public object MarshalNativeToManaged(IntPtr pNativeData)
        {
            if (pNativeData == IntPtr.Zero) return string.Empty;
            return Marshal.PtrToStringUni(pNativeData)!;
        }
    }
}
namespace System.Runtime.InteropServices
{
    public static partial class NativeLibrary
    {
        public static void Free(System.IntPtr handle) { }
        public static System.IntPtr GetMainProgramHandle() { throw null; }
        public static System.IntPtr GetExport(System.IntPtr handle, string name) { throw null; }
        public static System.IntPtr Load(string libraryPath) { throw null; }
        public static System.IntPtr Load(string libraryName, System.Reflection.Assembly assembly, System.Runtime.InteropServices.DllImportSearchPath? searchPath) { throw null; }
        public static void SetDllImportResolver(System.Reflection.Assembly assembly, System.Runtime.InteropServices.DllImportResolver resolver) { }
        public static bool TryGetExport(System.IntPtr handle, string name, out System.IntPtr address) { throw null; }
        public static bool TryLoad(string libraryPath, out System.IntPtr handle) { throw null; }
        public static bool TryLoad(string libraryName, System.Reflection.Assembly assembly, System.Runtime.InteropServices.DllImportSearchPath? searchPath, out System.IntPtr handle) { throw null; }
    }
}
namespace FFmpeg.NET.Internal
{
    [AttributeUsage(AttributeTargets.Delegate, Inherited = false)]
    public sealed class NativeMethodAttribute : Attribute
    {
        public NativeMethodAttribute(string nativeMethod)
        {
            NativeMethod = nativeMethod;
        }

        /// <summary>
        /// Called Native Method Name
        /// </summary>
        public string NativeMethod { get; }
    }
}
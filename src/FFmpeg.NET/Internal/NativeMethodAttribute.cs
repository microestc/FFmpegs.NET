using System;

namespace FFmpeg.NET.Internal
{
    [AttributeUsage(AttributeTargets.Delegate, Inherited = false, AllowMultiple = false)]
    public sealed class NativeMethodAttribute : Attribute
    {
        public NativeMethodAttribute(string method)
        {
            Method = method;
        }

        /// <summary>
        /// Called Native Method Name
        /// </summary>
        public string Method { get; }
    }
}
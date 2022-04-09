using System;

namespace FFmpeg.NET.Internal
{
    [AttributeUsage(AttributeTargets.Delegate, Inherited = false, AllowMultiple = false)]
    public sealed class NativeMethodAttribute : Attribute
    {
        public NativeMethodAttribute(string library, string method)
        {
            Library = library;
            Method = method;
        }

        /// <summary>
        /// Called Native Library Name
        /// </summary>
        public string Library { get; }

        /// <summary>
        /// Called Native Method Name
        /// </summary>
        public string Method { get; }
    }
}
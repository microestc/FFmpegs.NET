using System;

namespace FFmpeg.NET.Internal
{
    [AttributeUsage(AttributeTargets.Delegate, Inherited = false, AllowMultiple = false)]
    public sealed class NativeMethodAttribute : Attribute
    {
        public NativeMethodAttribute(Libraries library, string method)
        {
            Library = library;
            Method = method;
        }

        /// <summary>
        /// Called Native Library Name
        /// </summary>
        public Libraries Library { get; }

        /// <summary>
        /// Called Native Method Name
        /// </summary>
        public string Method { get; }
    }
}
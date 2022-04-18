using System;
using System.Reflection;

namespace FFmpeg.NET.Internal
{
    public class AttributeNotFoundException : Exception
    {
        public AttributeNotFoundException(MemberInfo element, Type target) : base(Strings.NotFoundAttribute(target.Name, element.Name))
        {
            Element = element;
            Target = target;
        }

        public MemberInfo Element { get; }

        public Type Target { get; }
    }
}
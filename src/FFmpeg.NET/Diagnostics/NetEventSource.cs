using System.Diagnostics.Tracing;

namespace System.Net
{
    [EventSource(Name = "FFmpeg.NET.Diagnostics")]
    internal sealed partial class NetEventSource : EventSource
    {
        internal static NetEventSource Log = new NetEventSource();
        
    }
}
using System.Diagnostics.Tracing;

namespace System.Net
{
    [EventSource(Name = "Diagnostics.FFmpeg.NET")]
    internal sealed partial class NetEventSource : EventSource
    {
        internal static NetEventSource Log = new NetEventSource();
        
    }
}
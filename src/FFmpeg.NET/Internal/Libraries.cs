namespace FFmpeg.NET
{
    public enum Libraries : byte
    {
        NONE = 0,
        AVUTIL = 1,
        SWSCALE = 2,
        POSTPROC = 3,
        SWRESAMPLE = 4,
        AVCODEC = 5,
        AVFORMAT = 6,
        AVFILTER = 7,
        AVDEVICE = 8
    }
}
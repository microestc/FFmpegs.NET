using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FFmpeg.NET;

namespace MsTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod()
    {
        // FFmpegapi.DLLDIR = "your_ffmpeg_dlls_path";

        var version = FFmpegapi.av_version_info();
        Console.WriteLine(version);

        var err = FFmpegapi.get_errorstr(-1179861752);
        Console.WriteLine(err);

        version = FFmpegapi.av_version_info();
        Console.WriteLine(version);

        err = FFmpegapi.get_errorstr(-1179861752);
        Console.WriteLine(err);

        // Console.WriteLine(Strings.CurrentPlatformNotsupported);
    }
}
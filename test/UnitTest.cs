using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FFmpegs.NET;

namespace MsTest;

[TestClass]
public class UnitTest
{
    [TestMethod]
    public void TestMethod()
    {
        // FFmpeg.DLLDIR = "your_ffmpeg_dlls_path";

        var version = FFmpeg.av_version_info(); // n5.0-42-g8fd2dc3f2b-20220330
        Assert.AreEqual(version, "n5.0-42-g8fd2dc3f2b-20220330");

        var err = FFmpeg.get_errorstr(-1179861752); // Bitstream filter not found
        Assert.AreEqual(err, "Bitstream filter not found");

        var eagain = FFmpegConst.EAGAIN;

        Assert.AreEqual(11, eagain);
    }
}
# FFmpegs.NET
This is a project that plans to build FFmpegs.NET dynamic libraries, it's call FFmpeg API on .NET Platform.

这是一个FFmpegs.NET的动态库，支持在 .NET 平台调用 FFmpeg API 接口。

## Setup

### 1. Example

Program.cs
```
using System;
using FFmpegs.NET;

// FFmpeg.DLLDIR = "your_ffmpeg_dlls_path";

var version = FFmpeg.av_version_info(); // n5.0-42-g8fd2dc3f2b-20220330
Assert.AreEqual(version, "n5.0-42-g8fd2dc3f2b-20220330");

var err = FFmpeg.get_errorstr(-1179861752); // Bitstream filter not found
Assert.AreEqual(err, "Bitstream filter not found");

var eagain = FFmpegConst.EAGAIN;

Assert.AreEqual(11, eagain);
```

### 2. Public Class
```
static class FFmpeg

static class FFmpegConst
```

### 3. Dynamic Library
FFmpeg dynamic library has somes defaults, but you can set custom the FFmpeg dynamic library path。

FFmpeg.NET 库默认包含了 FFmpeg 的动态库文件，不需要再次安装编译FFmpeg或动态库，当然你可以可以选择使用自己环境中的 FFmpeg 动态库。

方法如下
```
FFmpegapi.DLLDIR = "your_ffmpeg_dlls_path";
```
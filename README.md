# FFmpeg.NET
This is a project that plans to build FFmpeg.NET dynamic libraries, it's call FFmpeg API on .NET Platform.

这是一个FFmpeg.NET的动态库，支持在 .NET 平台调用 FFmpeg API 接口。

## Setup

### 1. Example

Program.cs
```
using System;
using FFmpeg.NET;

Console.WriteLine("Hello, Start!");

FFmpegapi.DLLDIR = "your_ffmpeg_dlls_path";

var version = FFmpegapi.av_version_info();
Console.WriteLine(version);

var err = FFmpegapi.GetError(-1179861752);
Console.WriteLine(err);

Console.WriteLine("Hello End!");
```

### 2. Public Class
```
static class FFmpegapi

static class FFmpegconst
```

### 3. Dynamic Library
FFmpeg dynamic library has somes defaults, but you can set custom the FFmpeg dynamic library path。

FFmpeg.NET 库默认包含了 FFmpeg 的动态库文件，不需要再次安装编译FFmpeg或动态库，当然你可以可以选择使用自己环境中的 FFmpeg 动态库。

方法如下
```
FFmpegapi.DLLDIR = "your_ffmpeg_dlls_path";
```
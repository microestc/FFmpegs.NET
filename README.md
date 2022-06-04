# FFmpeg.NET
This is a project that plans to build FFmpeg.NET dynamic libraries.

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
FFmpeg dynamic library has somes defaults, but you can set custom the FFmpeg dynamic library path
```
FFmpegapi.DLLDIR = "your_ffmpeg_dlls_path";
```
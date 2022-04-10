using System;
using FFmpeg.NET;

Console.WriteLine("Hello, Start!");
var api = new NativeApi(new FFmpegOptions{ DLLDIR = null });

var version = api.av_version_info();
Console.WriteLine(version);

var err = api.GetError(-1179861752);
Console.WriteLine(err);

Console.WriteLine("Hello End!");




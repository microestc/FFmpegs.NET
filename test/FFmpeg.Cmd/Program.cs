using System;
using FFmpeg.NET.Internal;

Console.WriteLine("Hello, Start!");

var version = NativeApi.Api.GetVersionInfo();
Console.WriteLine(version);

var err = NativeApi.Api.GetError(-1179861752);
Console.WriteLine(err);



Console.WriteLine("Hello End!");




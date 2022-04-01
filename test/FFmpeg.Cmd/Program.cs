using System;
using FFmpeg.NET.Internal;

Console.WriteLine("Hello, Start!");

var version = NativeApi.Api.GetVersionInfo();

Console.WriteLine(version);

Console.WriteLine("Hello End!");




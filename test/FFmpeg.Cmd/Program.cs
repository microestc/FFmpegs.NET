﻿using System;
using FFmpeg.NET;

Console.WriteLine("Hello, Start!");

var version = FFmpegapi.av_version_info();
Console.WriteLine(version);

var err = FFmpegapi.GetError(-1179861752);
Console.WriteLine(err);

Console.WriteLine("Hello End!");




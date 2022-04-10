using System;
using Microsoft.Extensions.DependencyInjection;

namespace FFmpeg.NET.Host
{
    public static class FFmpegServiceCollectionExtensions
    {
        public static IServiceCollection AddFFmpeg(this IServiceCollection services, Action<FFmpegOptions>? setupAction = null)
        {
            var options = new FFmpegOptions();
            if (setupAction != null) setupAction(options);

            services.AddSingleton<FFmpegApi>(new FFmpegApi(options));
            return services;
        }
    }
}
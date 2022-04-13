using FFmpeg.NET;
using Microsoft.AspNetCore.Mvc;

namespace FFmpeg.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class IndexController : ControllerBase
{
    private readonly ILogger<IndexController> _logger;

    public IndexController(ILogger<IndexController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "Index")]
    public IEnumerable<string> Get()
    {
        var version = FFmpegapi.av_version_info();
        Console.WriteLine(version);

        var err = FFmpegapi.GetError(-1179861752);
        Console.WriteLine(err);

        return new string[] { version, err! };
    }
}

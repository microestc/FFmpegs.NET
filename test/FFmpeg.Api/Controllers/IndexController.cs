using FFmpeg.NET;
using Microsoft.AspNetCore.Mvc;

namespace FFmpeg.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class IndexController : ControllerBase
{
    private readonly FFmpegApi _api;
    private readonly ILogger<IndexController> _logger;

    public IndexController(ILogger<IndexController> logger, FFmpegApi api)
    {
        _logger = logger;
        _api = api;
    }

    [HttpGet(Name = "Index")]
    public IEnumerable<string> Get()
    {
        var version = _api.av_version_info();
        Console.WriteLine(version);

        var err = _api.GetError(-1179861752);
        Console.WriteLine(err);

        return new string[] { version, err! };
    }
}

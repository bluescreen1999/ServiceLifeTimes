using ServiceLifeTimes.Services.Singleton;
using ServiceLifeTimes.Services.Transient;
using ServiceLifeTimes.Services.Scoped;
using ServiceLifeTimes.Services;
using Microsoft.AspNetCore.Mvc;

namespace ServiceLifeTimes.Controllers;

[ApiController]
[Route("[controller]")]
public class LifeTimesController : ControllerBase
{
    private readonly ITransientDateTimeService _transientDateTimeService;
    private readonly IScopedDateTimeService _scopedDateTimeService;
    private readonly ISingletonDateTimeService _singletonDateTimeService;
    private readonly ApplicationLogger _applicationLogger;

    public LifeTimesController(
        ITransientDateTimeService transientDateTimeService,
        IScopedDateTimeService scopedDateTimeService,
        ISingletonDateTimeService singletonDateTimeService,
        ApplicationLogger applicationLogger)
    {
        _transientDateTimeService = transientDateTimeService;
        _scopedDateTimeService = scopedDateTimeService;
        _singletonDateTimeService = singletonDateTimeService;
        _applicationLogger = applicationLogger;

        Console.WriteLine("========================================");
        Console.WriteLine($"(Transient) Service in controller: {_transientDateTimeService.CurrentUtcDateTime.ToString("yyyy-MM-dd HH:mm:ss.fffffff")}");
        Console.WriteLine($"(Scoped) Service in controller: {_scopedDateTimeService.CurrentUtcDateTime.ToString("yyyy-MM-dd HH:mm:ss.fffffff")}");
        Console.WriteLine($"(Singleton) Service in controller: {_singletonDateTimeService.CurrentUtcDateTime.ToString("yyyy-MM-dd HH:mm:ss.fffffff")}");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("============ End of Request ============");
        Console.ResetColor();
    }

    [HttpGet]
    public ActionResult<string> Get()
    {
        return "API Called!";
    }
}


using ServiceLifeTimes.Services.Singleton;
using ServiceLifeTimes.Services.Transient;
using ServiceLifeTimes.Services.Scoped;

namespace ServiceLifeTimes.Services;

public class ApplicationLogger
{
    private readonly ITransientDateTimeService _transientDateTimeService;
    private readonly IScopedDateTimeService _scopedDateTimeService;
    private readonly ISingletonDateTimeService _singletonDateTimeService;

    public ApplicationLogger(
        ITransientDateTimeService transientDateTimeService,
        IScopedDateTimeService scopedDateTimeService,
        ISingletonDateTimeService singletonDateTimeService)
    {
        _transientDateTimeService = transientDateTimeService;
        _scopedDateTimeService = scopedDateTimeService;
        _singletonDateTimeService = singletonDateTimeService;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("========= Beginning of Request =========");
        Console.ResetColor();
        Console.WriteLine($"(Transient) Logged at {_transientDateTimeService.CurrentUtcDateTime.ToString("yyyy-MM-dd HH:mm:ss.fffffff")}");
        Console.WriteLine($"(Scoped) Logged at {_scopedDateTimeService.CurrentUtcDateTime.ToString("yyyy-MM-dd HH:mm:ss.fffffff")}");
        Console.WriteLine($"(Singleton) Logged at {_singletonDateTimeService.CurrentUtcDateTime.ToString("yyyy-MM-dd HH:mm:ss.fffffff")}");
    }
}

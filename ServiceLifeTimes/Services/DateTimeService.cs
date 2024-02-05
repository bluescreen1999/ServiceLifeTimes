using ServiceLifeTimes.Services.Singleton;
using ServiceLifeTimes.Services.Transient;
using ServiceLifeTimes.Services.Scoped;

namespace ServiceLifeTimes.Services;

public class DateTimeService
    : ITransientDateTimeService, IScopedDateTimeService, ISingletonDateTimeService
{
    public DateTime CurrentUtcDateTime { get; }

    public DateTimeService()
    {
        CurrentUtcDateTime = DateTime.UtcNow;
    }
}

namespace ServiceLifeTimes.Services;

public interface IDateTimeService
{
    DateTime CurrentUtcDateTime { get; }
}

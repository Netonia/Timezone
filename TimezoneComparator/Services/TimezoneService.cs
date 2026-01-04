using Microsoft.JSInterop;
using NodaTime;

namespace TimezoneComparator.Services;

public class TimezoneService : ITimezoneService
{
    private readonly IJSRuntime _jsRuntime;

    public TimezoneService(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    public async Task<string> GetBrowserTimezoneAsync()
    {
        try
        {
            var timezone = await _jsRuntime.InvokeAsync<string>("getBrowserTimezone");
            return timezone ?? DateTimeZoneProviders.Tzdb.GetSystemDefault().Id;
        }
        catch
        {
            return DateTimeZoneProviders.Tzdb.GetSystemDefault().Id;
        }
    }

    public IEnumerable<string> GetAllTimezones()
    {
        return DateTimeZoneProviders.Tzdb.Ids.OrderBy(id => id);
    }
}

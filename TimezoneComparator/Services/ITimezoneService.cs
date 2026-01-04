namespace TimezoneComparator.Services;

public interface ITimezoneService
{
    Task<string> GetBrowserTimezoneAsync();
    IEnumerable<string> GetAllTimezones();
}

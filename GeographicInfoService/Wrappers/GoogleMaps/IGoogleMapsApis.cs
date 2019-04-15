using GeographicInfoEndpoint.Wrappers.GoogleMaps.Response;
using GeographicInfoEndpoint.Wrappers.OpenWeatherMap.Entities;
using System.Threading.Tasks;

namespace GeographicInfoEndpoint.Wrappers.GoogleMaps
{
    public interface IGoogleMapsApis
    {
        Task<ElevationResponse> GetElevationDataAsync(Coord coordinates);
        Task<TimeZoneResponse> GetTimeZoneDataAsync(Coord coordinates);
    }
}

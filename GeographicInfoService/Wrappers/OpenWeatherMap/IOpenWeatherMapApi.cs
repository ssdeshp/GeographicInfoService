using System.Threading.Tasks;
using GeographicInfoEndpoint.Wrappers.OpenWeatherMap.Response;

namespace GeographicInfoEndpoint.Wrappers.OpenWeatherMap
{
    public interface IOpenWeatherMapApi
    {
        Task<GetWeatherResponse> GetWeatherAsync(string zip);
    }
}

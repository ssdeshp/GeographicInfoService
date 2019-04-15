using System;
using System.Net.Http;
using System.Threading.Tasks;
using GeographicInfoEndpoint.Wrappers.GoogleMaps.Response;
using GeographicInfoEndpoint.Wrappers.OpenWeatherMap.Entities;
using Newtonsoft.Json;

namespace GeographicInfoEndpoint.Wrappers.GoogleMaps
{
    public class GoogleMapsApis : IGoogleMapsApis
    {
        private readonly HttpClient _httpClient;

        // Todo: Move apiKey to user screts : https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-2.2&tabs=windows
        // Please enter your apiKey for GoogleMap below
        private readonly string apiKey = "";

        public GoogleMapsApis(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ElevationResponse> GetElevationDataAsync(Coord coordinates)
        {
            string requestUri = $"/maps/api/elevation/json?locations={coordinates.Lat},{coordinates.Lon}&key={apiKey}";

            var responseString = await _httpClient.GetStringAsync(requestUri);
            return JsonConvert.DeserializeObject<ElevationResponse>(responseString);
        }

        public async Task<TimeZoneResponse> GetTimeZoneDataAsync(Coord coordinates)
        {
            string requestUri = $"/maps/api/timezone/json?location={coordinates.Lat},{coordinates.Lon}&timestamp={new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds()}&key={apiKey}";
            var responseString = await _httpClient.GetStringAsync(requestUri);
            return JsonConvert.DeserializeObject<TimeZoneResponse>(responseString);
        }
    }
}

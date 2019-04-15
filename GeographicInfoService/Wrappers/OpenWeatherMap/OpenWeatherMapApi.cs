
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using GeographicInfoEndpoint.Wrappers.OpenWeatherMap.Response;

namespace GeographicInfoEndpoint.Wrappers.OpenWeatherMap
{
    public class OpenWeatherMapApi : IOpenWeatherMapApi
    {
        private readonly HttpClient _httpClient;

        // Todo: Move apiKey to user screts : https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-2.2&tabs=windows
        // Please enter your apiKey for WeatherMap below
        private readonly string apiKey = "";


        public OpenWeatherMapApi(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<GetWeatherResponse> GetWeatherAsync(string zip)
        {
            string requestUri = $"data/2.5/weather?zip={zip},us&units=imperial&APPID={apiKey}";            

            var response = await _httpClient.GetAsync(requestUri);
            string jsonString = await response.Content.ReadAsStringAsync();               
            return JsonConvert.DeserializeObject<GetWeatherResponse>(jsonString);
                
        }
    }
}

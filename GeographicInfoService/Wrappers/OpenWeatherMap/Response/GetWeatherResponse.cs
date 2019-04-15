using GeographicInfoEndpoint.Wrappers.OpenWeatherMap.Entities;

namespace GeographicInfoEndpoint.Wrappers.OpenWeatherMap.Response
{
    public class GetWeatherResponse
    {
        public string Name { get; set; }

        public Main Main { get; set; }

        public Coord Coord { get; set; }

        public string Message { get; set; }
    }
}

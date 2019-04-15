using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GeographicInfoEndpoint.v1.Models;
using GeographicInfoEndpoint.Wrappers.GoogleMaps;
using GeographicInfoEndpoint.Wrappers.GoogleMaps.Response;
using GeographicInfoEndpoint.Wrappers.OpenWeatherMap;
using GeographicInfoEndpoint.Wrappers.OpenWeatherMap.Response;
using Microsoft.AspNetCore.Mvc;

namespace GeographicInfoEndpoint.v1.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ZipGeoController : ControllerBase
    {
        private IOpenWeatherMapApi _openWeatherMapApi;
        private IGoogleMapsApis _googleMapsApis;

        public ZipGeoController(IOpenWeatherMapApi openWeatherMapApi, IGoogleMapsApis googleMapsApis)
        {
            _openWeatherMapApi = openWeatherMapApi;
            _googleMapsApis = googleMapsApis;
        }

        // GET: api/v1/ZipGeo?zipcode=10010
        [HttpGet("")]
        public async Task<ActionResult<ZipGeoResponse>> GetZipGeo([FromQuery] string zipcode)
        {
            
            GetWeatherResponse weatherResponse = await _openWeatherMapApi.GetWeatherAsync(zipcode);

            if (!string.IsNullOrEmpty(weatherResponse.Message))
            {
                return NotFound(weatherResponse);
            }
            
            Task<TimeZoneResponse> timeZoneResponse = _googleMapsApis.GetTimeZoneDataAsync(weatherResponse.Coord);
            Task<ElevationResponse> elevationResponse = _googleMapsApis.GetElevationDataAsync(weatherResponse.Coord);

            await Task.WhenAll(timeZoneResponse, elevationResponse);

            return new ZipGeoResponse
            {
                ZipCode = zipcode,
                City = weatherResponse.Name,
                Temperature = weatherResponse.Main.Temp,
                TimeZoneName =  timeZoneResponse.Result.TimeZoneName,
                Elevation = elevationResponse.Result.Results[0].Elevation.ToString()
         
            };
        }
    }
}

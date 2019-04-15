# GeographicInfoService
# This project is a .Net Web API and Angular project that takes zip code as a parameter and returns city anme, current temperature, time zone and elevation of the location.
# The Angular UI then displays a user-friendly message.  This application uses Open WeatherMap API, Google Time Zone API and Google Elevation API.
#
#
#     1. Uses the Open WeatherMap current weather API to retrieve the current temperature and city name. You will be required to sign up for a free API key.
#     2. Uses the Google Time Zone API to get the current timezone for a location. You will again need to register a “project” and sign up for a free API key * with Google.
#     3. Uses the Google Elevation API to retrieve elevation data for a location.
#
#
# Update GeographicInfoEndpoint project with your registered API keys
#
# Update the apiKey variable in the following files:
# GeographicInfoEndpoint/Wrappers/OpenWeatherMap/OpenWeatherMapApi.cs
# GeographicInfoEndpoint/Wrappers/GoogleMaps/GoogleMapsApis.cs
#
# In the Angular project ZipGeo update the environment.ts file: zipgeoUrl with your .Net Web API project url
#
#


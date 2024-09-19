using OpenMeteo;
using Weather.API.Endpoints;

namespace Weather.API
{
    public static class MapsterConfig
    {
        public static void Configure()
        {
            TypeAdapterConfig<WeatherForecast, GetWeatherForecastResponse>.NewConfig()
                .Map(dest => dest.WeatherForecast, src => src);
        }
    }
}

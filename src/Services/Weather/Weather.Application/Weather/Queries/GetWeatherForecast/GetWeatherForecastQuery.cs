using OpenMeteo;

namespace Weather.Application.Weather.Queries.GetWeatherForecast;

public record GetWeatherForecastQuery(string location)
    : IQuery<GetWeatherForecastResult>;

public record GetWeatherForecastResult(WeatherForecast CurrentWeatherForecast,List<WeatherForecast> FiveDaysForecast);

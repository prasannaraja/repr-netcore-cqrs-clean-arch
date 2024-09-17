using OpenMeteo;

namespace Weather.Application.Weather.Queries.GetWeatherForecast;
public class GetWeatherForecastHandler(IOpenMeteoLibrary openMeteoLibrary)
    : IQueryHandler<GetWeatherForecastQuery, GetWeatherForecastResult>
{
    public async Task<GetWeatherForecastResult> Handle(GetWeatherForecastQuery query, CancellationToken cancellationToken)
    {
        var client = openMeteoLibrary.GetClient();
        WeatherForecast weatherData = await client.QueryAsync(query.location);

        return new GetWeatherForecastResult(weatherData);
    }
}

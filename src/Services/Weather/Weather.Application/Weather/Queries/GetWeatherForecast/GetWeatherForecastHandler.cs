using OpenMeteo;

namespace Weather.Application.Weather.Queries.GetWeatherForecast;
public class GetWeatherForecastHandler(IOpenMeteoLibrary openMeteoLibrary)
    : IQueryHandler<GetWeatherForecastQuery, GetWeatherForecastResult>
{
    public async Task<GetWeatherForecastResult> Handle(GetWeatherForecastQuery query, CancellationToken cancellationToken)
    {
        var client = openMeteoLibrary.GetClient();
        WeatherForecast weatherData = await client.QueryAsync(query.location);

        WeatherForecastOptions options = new ();
        options.Start_date = "2024-09-18";
        options.End_date = "2024-09-22";

        var forecast = await client.QueryAsync(query.location, options);

        return new GetWeatherForecastResult(weatherData, new() { forecast });
    }
}

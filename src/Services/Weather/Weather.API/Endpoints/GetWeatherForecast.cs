using OpenMeteo;
using Weather.Application.Weather.Queries.GetWeatherForecast;

namespace Weather.API.Endpoints;

public record GetWeatherForecastRequest(string Location);
public record GetWeatherForecastResponse(WeatherForecast WeatherForecast);

public class GetWeatherForecast : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/forecast", async (string location, ISender sender) =>
        {
            var result = await sender.Send(new GetWeatherForecastQuery(location));

            var response = result.CurrentWeatherForecast.Adapt<GetWeatherForecastResponse>();

            return Results.Ok(response);
        })
        .WithName("GetWeatherForecast")
        .Produces<GetWeatherForecastResponse>(StatusCodes.Status200OK)
        .ProducesProblem(StatusCodes.Status400BadRequest)
        .ProducesProblem(StatusCodes.Status404NotFound)
        .WithSummary("Get Weather Forecast")
        .WithDescription("Get Weather Forecast");
    }
}

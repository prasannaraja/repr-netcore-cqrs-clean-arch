using Microsoft.AspNetCore.Mvc;
using Weather.Application.Weather.Queries.GetOrders;

namespace Weather.API.Endpoints;

//- Accepts pagination parameters.
//- Constructs a GetOrdersQuery with these parameters.
//- Retrieves the data and returns it in a paginated format.

public record GetCurrentWeatherRequest(string Location);
public record GetCurrentWeatherResponse(string Result);

public class GetCurrentWeather : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/current", async ([FromBody] GetCurrentWeatherRequest model, ISender sender) =>
        {
            var result = await sender.Send(new GetCurrentWeatherQuery(model.Location));

            var response = result.Adapt<GetCurrentWeatherResponse>();

            return Results.Ok(response);
        })
        .WithName("GetCurrentWeather")
        .Produces<GetCurrentWeatherResponse>(StatusCodes.Status200OK)
        .ProducesProblem(StatusCodes.Status400BadRequest)
        .ProducesProblem(StatusCodes.Status404NotFound)
        .WithSummary("Get Current tWeather")
        .WithDescription("Get Current Weather");
    }
}

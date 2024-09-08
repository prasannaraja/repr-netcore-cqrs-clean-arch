using Weather.Application.Dtos;

namespace Weather.Application.Weather.Queries.GetOrdersByCustomer;

public record GetWeatherForecastQuery(string location)
    : IQuery<GetWeatherForecastResult>;

public record GetWeatherForecastResult(IEnumerable<OrderDto> Orders);

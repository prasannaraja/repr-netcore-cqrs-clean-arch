using BuildingBlocks.Pagination;

namespace Weather.Application.Weather.Queries.GetCurrentWeather;

public record GetCurrentWeatherQuery(string location)
    : IQuery<GetCurrentWeatherResult>;

public record GetCurrentWeatherResult(PaginatedResult<OrderDto> Orders);
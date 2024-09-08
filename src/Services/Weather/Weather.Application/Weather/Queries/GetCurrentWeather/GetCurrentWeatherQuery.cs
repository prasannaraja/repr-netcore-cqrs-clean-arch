using BuildingBlocks.Pagination;
using Weather.Application.Dtos;

namespace Weather.Application.Weather.Queries.GetOrders;

public record GetCurrentWeatherQuery(string location)
    : IQuery<GetCurrentWeatherResult>;

public record GetCurrentWeatherResult(PaginatedResult<OrderDto> Orders);
namespace Weather.Application.Weather.Queries.GetCurrentWeather;
public class GetCurrentWeatherHandler(IApplicationDbContext dbContext)
    : IQueryHandler<GetCurrentWeatherQuery, GetCurrentWeatherResult>
{
    public async Task<GetCurrentWeatherResult> Handle(GetCurrentWeatherQuery query, CancellationToken cancellationToken)
    {
        // get orders with pagination
        // return result

        //var pageIndex = query.PaginationRequest.PageIndex;
        //var pageSize = query.PaginationRequest.PageSize;

        //var totalCount = await dbContext.Orders.LongCountAsync(cancellationToken);

        //var orders = await dbContext.Orders
        //               .Include(o => o.OrderItems)
        //               .OrderBy(o => o.OrderName.Value)
        //               .Skip(pageSize * pageIndex)
        //               .Take(pageSize)
        //               .ToListAsync(cancellationToken);

        //return new GetCurrentWeatherResult(
        //    new PaginatedResult<OrderDto>(
        //        pageIndex,
        //        pageSize,
        //        totalCount,
        //        orders.ToOrderDtoList()));

        return default;
    }
}

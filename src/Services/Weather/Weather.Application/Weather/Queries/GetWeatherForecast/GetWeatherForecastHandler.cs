using Weather.Application.Data;
using Weather.Domain.ValueObjects;

namespace Weather.Application.Weather.Queries.GetOrdersByCustomer;
public class GetWeatherForecastHandler(IApplicationDbContext dbContext)
    : IQueryHandler<GetWeatherForecastQuery, GetWeatherForecastResult>
{
    public async Task<GetWeatherForecastResult> Handle(GetWeatherForecastQuery query, CancellationToken cancellationToken)
    {
        // get orders by customer using dbContext
        // return result

        //var orders = await dbContext.Orders
        //                .Include(o => o.OrderItems)
        //                .AsNoTracking()
        //                .Where(o => o.CustomerId == CustomerId.Of(query.CustomerId))
        //                .OrderBy(o => o.OrderName.Value)
        //                .ToListAsync(cancellationToken);

        //return new GetWeatherForecastResult(orders.ToOrderDtoList());
        return default;
    }
}

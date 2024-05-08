using System.Net.Http.Headers;

namespace LinqTraining.Data;

public class OrderGrouping
{
    public Order Order { get; set; }
    public string GroupName { get; set; } = string.Empty;
}

public class OrderGroupingService
{
    private readonly List<OrderGrouping> _orderGrouping;
    private readonly List<Order> _orders;

    public OrderGroupingService()
    {
        _orders = new OrderService().GetOrders();
        _orderGrouping = _orders.Select(x => new OrderGrouping { Order = x, GroupName = x.Amount > 2 ? "VIP" : "Normal" }).ToList();
    }

    public List<OrderGrouping> GetOrderGroupings()
    {
        return _orderGrouping;
    }
}
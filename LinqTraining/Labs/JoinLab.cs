using LinqTraining.Data;

namespace LinqTraining.Labs;

public class JoinLab
{
    private readonly List<Product> _products;
    private readonly List<Order> _orders;
    private readonly List<OrderGrouping> _orderGroupings;

    public JoinLab()
    {
        _products = new ProductService().GetProducts();
        _orders = new OrderService().GetOrders();
        _orderGroupings = new OrderGroupingService().GetOrderGroupings();
    }

    public List<string> GetBuyersByTotalHigherThen500()
    {
        var result = new List<string>();

        // TODO: Product Join Order, and Get Buyer whose Total is higher Then 500

        return result;
    }

    public List<string> GetBuyersInWhichGroup()
    {
        var result = new List<string>();
        // TODO: Order Join OrderGrouping, and Get Buyer in Which Group (Output template: Buyer in GroupName)

        return result;
    }
}
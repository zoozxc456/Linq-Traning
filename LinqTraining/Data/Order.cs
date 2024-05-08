namespace LinqTraining.Data;

public class Order
{
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public string Buyer { get; set; } = string.Empty;
    public int Amount { get; set; }
}

public class OrderService
{
    private readonly List<Order> _order;

    public OrderService()
    {
        _order = new List<Order>
        {
            new() { OrderId = 1, ProductId = 3, Amount = 2, Buyer = "Tim" },
            new() { OrderId = 2, ProductId = 1, Amount = 5, Buyer = "Tracy" },
            new() { OrderId = 3, ProductId = 4, Amount = 1, Buyer = "Mary" },
            new() { OrderId = 4, ProductId = 5, Amount = 2, Buyer = "Tina" },
            new() { OrderId = 5, ProductId = 2, Amount = 1, Buyer = "Jason" },
            new() { OrderId = 6, ProductId = 4, Amount = 2, Buyer = "Ben" },
        };
    }

    public List<Order> GetOrders()
    {
        return _order;
    }
}
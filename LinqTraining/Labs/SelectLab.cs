using LinqTraining.Data;

namespace LinqTraining.Labs;

public class SelectLab
{
    private readonly List<Product> _products;

    public SelectLab()
    {
        _products = new ProductService().GetProducts();
    }

    public List<string> GetAllProductName()
    {
        var result = new List<string>();

        // TODO: Select All Product Name using Linq

        return result;
    }

    public List<Product> GetAllProductIdAndNameAndPrice()
    {
        var result = new List<Product>();

        // TODO: Select All Product Id, Name, Price using Linq

        return result;
    }

    public List<Product> GetAllProductsWithDoublePrice()
    {
        var result = new List<Product>();

        // TODO: Select All Products(All Attributes need to output) and the price need to exchange to double price using Linq

        return result;
    }
}
using LinqTraining.Data;

namespace LinqTraining.Labs;

public class OrderLab
{
    private readonly List<Product> _products;

    public OrderLab()
    {
        _products = new ProductService().GetProducts();
    }

    public List<Product> GetAllProductsSortedByPriceAscending()
    {
        var result = new List<Product>();
        // TODO: Get all products which is sorted by price ascending

        return result;
    }

    public List<Product> GetAllProductsSortedByReleaseDateAscendingAndThenIdDescending()
    {
        var result = new List<Product>();
        // TODO: Get all products which is sorted by ReleaseDate ascending, if both ,sorted by id Descending

        return result;
    }

    public List<Product> GetAllProductSortedByCustomStrategy()
    {
        var result = new List<Product>();
        // TODO: Get all products which is sorted by custom strategy, if both ,sorted by id Descending
        
        // Custom Strategy
        // 1. Name contains “Pro“, needs placing to first
        // 2. If both are Pro, sorted by Price ascending.
        // 3. If neither is Pro, sorted by Id descending
        
        return result;
    }
}
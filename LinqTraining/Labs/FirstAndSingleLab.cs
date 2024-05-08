using LinqTraining.Data;

namespace LinqTraining.Labs;

public class FirstAndSingleLab
{
    private readonly List<Product> _products;

    public FirstAndSingleLab()
    {
        _products = new ProductService().GetProducts();
    }

    public Product GetProductByPriceLowerThan300()
    {
        var result = new Product();
        // TODO: Get the product whose price lower than 300 using Linq(Single)
        
        return result;
    }

    public Product? GetProductByIdEqualTo8()
    {
        var result = new Product();
        // TODO: Get the product whose id equal to 8 using Linq(SingleOrDefault)
        
        return result;
    }

    public Product GetProductByNameAndPrice(string productName, double price)
    {
        var result = new Product();
        // TODO: Get the product whose name and price matched the specific parameters using Linq(First)
        
        return result;
    }

    public Product? GetProductByReleaseDateAndPrice(DateOnly releaseDate, double price)
    {
        var result = new Product();
        // TODO: Get the product whose release date and price matched the specific parameters using Linq(FirstOrDefault)

        return result;
    }
}

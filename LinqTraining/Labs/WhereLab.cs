using LinqTraining.Data;

namespace LinqTraining.Labs;

public class WhereLab
{
    private readonly List<Product> _products;

    public WhereLab()
    {
        _products = new ProductService().GetProducts();
    }

    public List<Product> GetProductsByPriceHigherThan350()
    {
        var result = new List<Product>();

        // TODO: Filter Product Price Higher Than 350 using Linq

        return result;
    }

    public List<Product> GetProductsByNameAndReleaseDate(string specificString, DateOnly specificDate)
    {
        var result = new List<Product>();

        // TODO: Filter Product Name Contain specificString and ReleaseDate Later Than specificDate using Linq

        return result;
    }
}
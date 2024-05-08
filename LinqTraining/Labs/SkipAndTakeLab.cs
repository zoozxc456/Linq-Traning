using LinqTraining.Data;

namespace LinqTraining.Labs;

public class SkipAndTakeLab
{
    private readonly List<Product> _products;

    public SkipAndTakeLab()
    {
        _products = new ProductService().GetProducts();
    }

    public List<Product> Skip2Products()
    {
        var result = new List<Product>();
        
        // TODO: Skip 2 records

        return result;
    }

    public List<Product> Take5Products()
    {
        var result = new List<Product>();
        
        // TODO: Take 5 records

        return result;
    }

    public List<Product> Skip2ThenTake5Products()
    {
        var result = new List<Product>();
       
        // TODO: Skip 2 records and then Take 5 records

        return result;
    }
}

using LinqTraining.Data;

namespace LinqTraining.Labs;

public class GroupLab
{
    private readonly List<Product> _products;

    public GroupLab()
    {
        _products = new ProductService().GetProducts();
    }

    public List<IGrouping<DateOnly, Product>> GroupByReleaseDate()
    {
        var result = new List<IGrouping<DateOnly, Product>>();
        // TODO: Group By Release Date

        return result;
    }

    public List<IGrouping<TempObj, Product>> GroupByReleaseDateAndPrice()
    {
        var result = new List<IGrouping<TempObj, Product>>();
        // TODO: Group By Release Date and Price

        return result;
    }

    public class TempObj
    {
        public DateOnly ReleaseDate { get; set; }
        public double Price { get; set; }
    }
}
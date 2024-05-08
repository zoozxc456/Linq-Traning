using LinqTraining.Data;

namespace LinqTraining.Labs;

public class CollectionSetLab
{
    private readonly List<Product> _products;

    public CollectionSetLab()
    {
        _products = new ProductService().GetProducts();
    }

    public double GetMaxPrice()
    {
        var result = 0.0;

        // TODO: Get the most expensive product price

        return result;
    }

    public Product? GetMaxPriceProduct()
    {
        var result = new Product();

        // TODO: Get the most expensive product

        return result;
    }

    public double GetMinPrice()
    {
        var result = 0.0;

        // TODO: Get the cheapest product price

        return result;
    }

    public Product? GetMinPriceProduct()
    {
        var result = new Product();

        // TODO: Get the cheapest product

        return result;
    }

    public List<int> GetUnion()
    {
        var list1 = new List<int> { 1, 3, 5, 7, 9 };
        var list2 = new List<int> { 2, 4, 6, 8, 10 };

        var result = new List<int>();
        // TODO: Union list1 and list2

        return result;
    }

    public List<int> GetExpect()
    {
        var list1 = new List<int> { 1, 3, 5, 7, 9 };
        var list2 = new List<int> { 2, 3, 6, 7, 9 };

        var result = new List<int>();
        // TODO: list1 expect list2

        return result;
    }

    public List<int> GetIntersect()
    {
        var list1 = new List<int> { 1, 3, 5, 7, 9 };
        var list2 = new List<int> { 2, 3, 6, 7, 9 };

        var result = new List<int>();
        // TODO: Intersect list1 and list2

        return result;
    }

    public double TotalProductPrice()
    {
        var result = 0.0;

        // TODO: Get all products price amount

        return result;
    }

    public double TotalProductPriceUsingAggregate()
    {
        var result = 0.0;

        // TODO: Get all products price amount(using Aggregate)

        return result;
    }

    public double AverageProductPrice()
    {
        var result = 0.0;

        // TODO: Get all products price average

        return result;
    }

    public bool IsAllProductPriceHigherThan350()
    {
        bool result = default;

        // TODO: Check all product price is higher than 350

        return result;
    }

    public bool IsAnyProductPriceHigherThan400()
    {
        bool result = default;

        // TODO: Check any product price is higher than 350

        return result;
    }

    public List<Product> FlatProducts()
    {
        var productLayers = new List<List<Product>>()
        {
            new()
            {
                new() { Id = 1, Name = "iPhone 15", Price = 399, ReleaseDate = new DateOnly(2023, 10, 1) },
                new() { Id = 2, Name = "iPhone 15 Plus", Price = 419, ReleaseDate = new DateOnly(2023, 10, 1) }
            },
            new()
            {
                new() { Id = 3, Name = "iPhone 15 Pro", Price = 479, ReleaseDate = new DateOnly(2023, 10, 1) },
                new() { Id = 4, Name = "iPhone 15 Pro Max", Price = 499, ReleaseDate = new DateOnly(2023, 10, 1) }
            },
            new()
            {
                new() { Id = 5, Name = "iPhone 14", Price = 299, ReleaseDate = new DateOnly(2022, 8, 1) },
                new() { Id = 6, Name = "iPhone 14 Plus", Price = 319, ReleaseDate = new DateOnly(2022, 8, 1) }
            },
            new()
            {
                new() { Id = 7, Name = "iPhone 14 Pro", Price = 359, ReleaseDate = new DateOnly(2022, 10, 1) },
                new() { Id = 8, Name = "iPhone 14 Pro Max", Price = 379, ReleaseDate = new DateOnly(2022, 10, 1) }
            },
        };

        var result = new List<Product>();

        // TODO: Flat product layers (From Second Dimension to First Dimension)

        return result;
    }
}
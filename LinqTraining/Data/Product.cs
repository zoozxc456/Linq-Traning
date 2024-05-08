namespace LinqTraining.Data;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public double Price { get; set; }
    public DateOnly ReleaseDate { get; set; }
}

public class ProductService
{
    private readonly List<Product> _products;

    public ProductService()
    {
        _products = new List<Product>
        {
            new() { Id = 1, Name = "iPhone 15", Price = 399, ReleaseDate = new DateOnly(2023, 10, 1) },
            new() { Id = 2, Name = "iPhone 15 Plus", Price = 419, ReleaseDate = new DateOnly(2023, 10, 1) },
            new() { Id = 3, Name = "iPhone 15 Pro", Price = 479, ReleaseDate = new DateOnly(2023, 10, 1) },
            new() { Id = 4, Name = "iPhone 15 Pro Max", Price = 499, ReleaseDate = new DateOnly(2023, 10, 1) },
            new() { Id = 5, Name = "iPhone 14", Price = 299, ReleaseDate = new DateOnly(2022, 8, 1) },
            new() { Id = 6, Name = "iPhone 14 Plus", Price = 319, ReleaseDate = new DateOnly(2022, 8, 1) },
            new() { Id = 7, Name = "iPhone 14 Pro", Price = 359, ReleaseDate = new DateOnly(2022, 10, 1) },
            new() { Id = 8, Name = "iPhone 14 Pro Max", Price = 379, ReleaseDate = new DateOnly(2022, 10, 1) }
        };
    }

    public List<Product> GetProducts()
    {
        return _products;
    }
}
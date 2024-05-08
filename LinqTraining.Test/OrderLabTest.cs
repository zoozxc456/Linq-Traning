using ExpectedObjects;
using LinqTraining.Data;
using LinqTraining.Labs;

namespace LinqTraining.Test;

[TestFixture]
public class OrderLabTest
{
    private readonly OrderLab _orderLab;

    public OrderLabTest()
    {
        _orderLab = new OrderLab();
    }

    [Test]
    public void GetAllProductsSortedByPriceAscending()
    {
        var expected = new List<Product>
        {
            new() { Id = 5, Name = "iPhone 14", Price = 299, ReleaseDate = new DateOnly(2022, 8, 1) },
            new() { Id = 6, Name = "iPhone 14 Plus", Price = 319, ReleaseDate = new DateOnly(2022, 8, 1) },
            new() { Id = 7, Name = "iPhone 14 Pro", Price = 359, ReleaseDate = new DateOnly(2022, 10, 1) },
            new() { Id = 8, Name = "iPhone 14 Pro Max", Price = 379, ReleaseDate = new DateOnly(2022, 10, 1) },
            new() { Id = 1, Name = "iPhone 15", Price = 399, ReleaseDate = new DateOnly(2023, 10, 1) },
            new() { Id = 2, Name = "iPhone 15 Plus", Price = 419, ReleaseDate = new DateOnly(2023, 10, 1) },
            new() { Id = 3, Name = "iPhone 15 Pro", Price = 479, ReleaseDate = new DateOnly(2023, 10, 1) },
            new() { Id = 4, Name = "iPhone 15 Pro Max", Price = 499, ReleaseDate = new DateOnly(2023, 10, 1) }
        }.ToExpectedObject(ctx => ctx.UseOrdinalComparison());

        var result = _orderLab.GetAllProductsSortedByPriceAscending();
        expected.ShouldEqual(result.ToList());
    }

    [Test]
    public void GetAllProductsSortedByReleaseDateAscendingAndThenIdDescending()
    {
        var expected = new List<Product>
       {
            new() { Id = 6, Name = "iPhone 14 Plus", Price = 319, ReleaseDate = new DateOnly(2022, 8, 1) },
            new() { Id = 5, Name = "iPhone 14", Price = 299, ReleaseDate = new DateOnly(2022, 8, 1) },
            new() { Id = 8, Name = "iPhone 14 Pro Max", Price = 379, ReleaseDate = new DateOnly(2022, 10, 1) },
            new() { Id = 7, Name = "iPhone 14 Pro", Price = 359, ReleaseDate = new DateOnly(2022, 10, 1) },
            new() { Id = 4, Name = "iPhone 15 Pro Max", Price = 499, ReleaseDate = new DateOnly(2023, 10, 1) },
            new() { Id = 3, Name = "iPhone 15 Pro", Price = 479, ReleaseDate = new DateOnly(2023, 10, 1) },
            new() { Id = 2, Name = "iPhone 15 Plus", Price = 419, ReleaseDate = new DateOnly(2023, 10, 1) },
            new() { Id = 1, Name = "iPhone 15", Price = 399, ReleaseDate = new DateOnly(2023, 10, 1) }
        }.ToExpectedObject(ctx => ctx.UseOrdinalComparison());

        var result = _orderLab.GetAllProductsSortedByReleaseDateAscendingAndThenIdDescending();

        expected.ShouldEqual(result);
    }

    [Test]
    public void GetAllProductSortedByCustomStrategy()
    {
        var expected = new List<Product>
       {
            new() { Id = 7, Name = "iPhone 14 Pro", Price = 359, ReleaseDate = new DateOnly(2022, 10, 1) },
            new() { Id = 8, Name = "iPhone 14 Pro Max", Price = 379, ReleaseDate = new DateOnly(2022, 10, 1) },
            new() { Id = 3, Name = "iPhone 15 Pro", Price = 479, ReleaseDate = new DateOnly(2023, 10, 1) },
            new() { Id = 4, Name = "iPhone 15 Pro Max", Price = 499, ReleaseDate = new DateOnly(2023, 10, 1) },
            new() { Id = 1, Name = "iPhone 15", Price = 399, ReleaseDate = new DateOnly(2023, 10, 1) },
            new() { Id = 2, Name = "iPhone 15 Plus", Price = 419, ReleaseDate = new DateOnly(2023, 10, 1) },
            new() { Id = 5, Name = "iPhone 14", Price = 299, ReleaseDate = new DateOnly(2022, 8, 1) },
            new() { Id = 6, Name = "iPhone 14 Plus", Price = 319, ReleaseDate = new DateOnly(2022, 8, 1) },
        }.ToExpectedObject(ctx => ctx.UseOrdinalComparison());

        var result = _orderLab.GetAllProductSortedByCustomStrategy();

        expected.ShouldEqual(result);
    }
}
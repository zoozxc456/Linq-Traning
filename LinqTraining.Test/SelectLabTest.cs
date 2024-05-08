using ExpectedObjects;
using LinqTraining.Data;
using LinqTraining.Labs;

namespace LinqTraining.Test;

[TestFixture]
public class SelectLabTest
{
    private readonly SelectLab _selectLab;
    private ExpectedObject? _expected;

    public SelectLabTest()
    {
        _selectLab = new SelectLab();
    }

    [Test]
    public void GetAllProductName_GiveExpectProductNames_ShouldReturnAllProductNameStrings()
    {
        GiveExceptedAllProductNameStrings();
        ShouldReturnAllProductNameStrings();
    }

    [Test]
    public void GetAllProductIdAndNameAndPrice_GiveExceptedProducts_ShouldReturnAllProductIdAndNameAndPrice()
    {
        GiveExceptedProductIdAndNameAndPrice();
        ShouldReturnAllProductIdAndNameAndPrice();
    }

    [Test]
    public void GetAllProductsWithDoublePrice()
    {
        var expected = new List<Product>
        {
            new() { Id = 1, Name = "iPhone 15", Price = 399 * 2, ReleaseDate = new DateOnly(2023, 10, 1) },
            new() { Id = 2, Name = "iPhone 15 Plus", Price = 419 * 2, ReleaseDate = new DateOnly(2023, 10, 1) },
            new() { Id = 3, Name = "iPhone 15 Pro", Price = 479 * 2, ReleaseDate = new DateOnly(2023, 10, 1) },
            new() { Id = 4, Name = "iPhone 15 Pro Max", Price = 499 * 2, ReleaseDate = new DateOnly(2023, 10, 1) },
            new() { Id = 5, Name = "iPhone 14", Price = 299 * 2, ReleaseDate = new DateOnly(2022, 8, 1) },
            new() { Id = 6, Name = "iPhone 14 Plus", Price = 319 * 2, ReleaseDate = new DateOnly(2022, 8, 1) },
            new() { Id = 7, Name = "iPhone 14 Pro", Price = 359 * 2, ReleaseDate = new DateOnly(2022, 10, 1) },
            new() { Id = 8, Name = "iPhone 14 Pro Max", Price = 379 * 2, ReleaseDate = new DateOnly(2022, 10, 1) }
        }.ToExpectedObject();

        var result = _selectLab.GetAllProductsWithDoublePrice();

        expected.ShouldEqual(result);
    }

    private void ShouldReturnAllProductNameStrings()
    {
        var result = _selectLab.GetAllProductName();
        _expected.ShouldEqual(result);
    }

    private void GiveExceptedAllProductNameStrings()
    {
        _expected = new List<string>
        {
            "iPhone 15", "iPhone 15 Plus", "iPhone 15 Pro", "iPhone 15 Pro Max",
            "iPhone 14", "iPhone 14 Plus", "iPhone 14 Pro", "iPhone 14 Pro Max"
        }.ToExpectedObject();
    }

    private void ShouldReturnAllProductIdAndNameAndPrice()
    {
        var result = _selectLab.GetAllProductIdAndNameAndPrice();
        _expected.ShouldEqual(result);
    }

    private void GiveExceptedProductIdAndNameAndPrice()
    {
        _expected = new List<Product>
        {
            new() { Id = 1, Name = "iPhone 15", Price = 399 },
            new() { Id = 2, Name = "iPhone 15 Plus", Price = 419 },
            new() { Id = 3, Name = "iPhone 15 Pro", Price = 479 },
            new() { Id = 4, Name = "iPhone 15 Pro Max", Price = 499 },
            new() { Id = 5, Name = "iPhone 14", Price = 299 },
            new() { Id = 6, Name = "iPhone 14 Plus", Price = 319 },
            new() { Id = 7, Name = "iPhone 14 Pro", Price = 359 },
            new() { Id = 8, Name = "iPhone 14 Pro Max", Price = 379 }
        }.ToExpectedObject();
    }
}
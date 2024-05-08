using ExpectedObjects;
using LinqTraining.Data;
using LinqTraining.Labs;

namespace LinqTraining.Test;

[TestFixture]
public class CollectionSetLabTest
{
    private readonly CollectionSetLab _collectionSetLab;

    public CollectionSetLabTest()
    {
        _collectionSetLab = new CollectionSetLab();
    }

    [Test]
    public void AverageProductPrice()
    {
        var expected = (394.0).ToExpectedObject();

        var result = _collectionSetLab.AverageProductPrice();
        expected.ShouldEqual(result);
    }

    [Test]
    public void FlatProducts()
    {
        var expected = new List<Product>
        {
            new() { Id = 1, Name = "iPhone 15", Price = 399, ReleaseDate = new DateOnly(2023, 10, 1) },
            new() { Id = 2, Name = "iPhone 15 Plus", Price = 419, ReleaseDate = new DateOnly(2023, 10, 1) },
            new() { Id = 3, Name = "iPhone 15 Pro", Price = 479, ReleaseDate = new DateOnly(2023, 10, 1) },
            new() { Id = 4, Name = "iPhone 15 Pro Max", Price = 499, ReleaseDate = new DateOnly(2023, 10, 1) },
            new() { Id = 5, Name = "iPhone 14", Price = 299, ReleaseDate = new DateOnly(2022, 8, 1) },
            new() { Id = 6, Name = "iPhone 14 Plus", Price = 319, ReleaseDate = new DateOnly(2022, 8, 1) },
            new() { Id = 7, Name = "iPhone 14 Pro", Price = 359, ReleaseDate = new DateOnly(2022, 10, 1) },
            new() { Id = 8, Name = "iPhone 14 Pro Max", Price = 379, ReleaseDate = new DateOnly(2022, 10, 1) }
        }.ToExpectedObject();

        var result = _collectionSetLab.FlatProducts();
        expected.ShouldEqual(result);
    }

    [Test]
    public void TotalProductPrice()
    {
        var expected = (3152.0).ToExpectedObject();

        var result = _collectionSetLab.TotalProductPrice();
        expected.ShouldEqual(result);
    }

    [Test]
    public void TotalProductPriceUsingAggregate()
    {
        var expected = (3152.0).ToExpectedObject();

        var result = _collectionSetLab.TotalProductPriceUsingAggregate();
        expected.ShouldEqual(result);
    }

    [Test]
    public void GetExpect()
    {
        var expected = new List<int> { 1, 5 }.ToExpectedObject();

        var result = _collectionSetLab.GetExpect();
        expected.ShouldEqual(result);
    }

    [Test]
    public void GetIntersect()
    {
        var expected = new List<int> { 3, 7, 9 }.ToExpectedObject();

        var result = _collectionSetLab.GetIntersect();
        expected.ShouldEqual(result);
    }

    [Test]
    public void GetUnion()
    {
        var expected = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }.ToExpectedObject();

        var result = _collectionSetLab.GetUnion();
        expected.ShouldEqual(result);
    }

    [Test]
    public void GetMaxPrice()
    {
        var expected = (499.0).ToExpectedObject();

        var result = _collectionSetLab.GetMaxPrice();
        expected.ShouldEqual(result);
    }

    [Test]
    public void GetMaxPriceProduct()
    {
        var expected = new Product { Id = 4, Name = "iPhone 15 Pro Max", Price = 499, ReleaseDate = new DateOnly(2023, 10, 1) }.ToExpectedObject();

        var result = _collectionSetLab.GetMaxPriceProduct();
        expected.ShouldEqual(result);
    }

    [Test]
    public void GetMinPrice()
    {
        var expected = (299.0).ToExpectedObject();

        var result = _collectionSetLab.GetMinPrice();
        expected.ShouldEqual(result);
    }

    [Test]
    public void GetMinPriceProduct()
    {
        var expected = new Product { Id = 5, Name = "iPhone 14", Price = 299, ReleaseDate = new DateOnly(2022, 8, 1) }.ToExpectedObject();

        var result = _collectionSetLab.GetMinPriceProduct();
        expected.ShouldEqual(result);
    }

    [Test]
    public void IsAllProductPriceHigherThan350()
    {
        var expected = false.ToExpectedObject();

        var result = _collectionSetLab.IsAllProductPriceHigherThan350();
        expected.ShouldEqual(result);
    }

    [Test]
    public void IsAnyProductPriceHigherThan400()
    {
        var expected = true.ToExpectedObject();

        var result = _collectionSetLab.IsAnyProductPriceHigherThan400();
        expected.ShouldEqual(result);
    }
}
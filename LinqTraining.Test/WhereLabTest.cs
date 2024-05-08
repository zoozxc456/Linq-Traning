using ExpectedObjects;
using LinqTraining.Data;
using LinqTraining.Labs;

namespace LinqTraining.Test;

[TestFixture]
public class WhereLabTest
{
    private readonly WhereLab _whereLab;

    public WhereLabTest()
    {
        _whereLab = new WhereLab();
    }

    [Test]
    public void GetProductsByPriceHigherThan350()
    {
        var expected = new List<Product>
        {
            new() { Id = 1, Name = "iPhone 15", Price = 399, ReleaseDate = new DateOnly(2023, 10, 1) },
            new() { Id = 2, Name = "iPhone 15 Plus", Price = 419, ReleaseDate = new DateOnly(2023, 10, 1) },
            new() { Id = 3, Name = "iPhone 15 Pro", Price = 479, ReleaseDate = new DateOnly(2023, 10, 1) },
            new() { Id = 4, Name = "iPhone 15 Pro Max", Price = 499, ReleaseDate = new DateOnly(2023, 10, 1) },
            new() { Id = 7, Name = "iPhone 14 Pro", Price = 359, ReleaseDate = new DateOnly(2022, 10, 1) },
            new() { Id = 8, Name = "iPhone 14 Pro Max", Price = 379, ReleaseDate = new DateOnly(2022, 10, 1) }
        }.ToExpectedObject();

        var result = _whereLab.GetProductsByPriceHigherThan350();

        expected.ShouldEqual(result);
    }

    [Test]
    public void GetProductsByNameAndReleaseDate_GiveSpecificStringAndDate_ShouldReturnExceptedProducts()
    {
        var expected = new List<Product>
        {
            new() { Id = 3, Name = "iPhone 15 Pro", Price = 479, ReleaseDate = new DateOnly(2023, 10, 1) },
            new() { Id = 4, Name = "iPhone 15 Pro Max", Price = 499, ReleaseDate = new DateOnly(2023, 10, 1) },
        }.ToExpectedObject();

        var result = _whereLab.GetProductsByNameAndReleaseDate("Pro", new DateOnly(2023, 2, 1));

        expected.ShouldEqual(result);
    }
}
using ExpectedObjects;
using LinqTraining.Data;
using LinqTraining.Labs;

namespace LinqTraining.Test;

[TestFixture]
public class FirstAndSingleLabTest
{
    private readonly FirstAndSingleLab _firstAndSingleLab;

    public FirstAndSingleLabTest()
    {
        _firstAndSingleLab = new FirstAndSingleLab();
    }

    [Test]
    public void GetProductByPriceLowerThan300()
    {
        var expected = new Product
        {
            Id = 5,
            Name = "iPhone 14",
            Price = 299,
            ReleaseDate = new DateOnly(2022, 8, 1)
        }.ToExpectedObject();

        var result = _firstAndSingleLab.GetProductByPriceLowerThan300();
        expected.ShouldEqual(result);
    }

    [Test]
    public void GetProductByIdEqualTo8()
    {
        var expected = new Product
        {
            Id = 8,
            Name = "iPhone 14 Pro Max",
            Price = 379,
            ReleaseDate = new DateOnly(2022, 10, 1)
        }.ToExpectedObject();

        var result = _firstAndSingleLab.GetProductByIdEqualTo8();

        expected.ShouldEqual(result);
    }

    [Test]
    public void GetProductByNameAndPrice()
    {
        var expected = new Product
        {
            Id = 1,
            Name = "iPhone 15",
            Price = 399,
            ReleaseDate = new DateOnly(2023, 10, 1)
        }.ToExpectedObject();

        var result = _firstAndSingleLab.GetProductByNameAndPrice("iPhone 15", 399);

        expected.ShouldEqual(result);
    }

    [Test]
    public void GetProductByReleaseDateAndPrice()
    {
        var expected = new Product
        {
            Id = 1,
            Name = "iPhone 15",
            Price = 399,
            ReleaseDate = new DateOnly(2023, 10, 1)
        }.ToExpectedObject();

        var result = _firstAndSingleLab.GetProductByReleaseDateAndPrice(new DateOnly(2023, 2, 1), 399);

        expected.ShouldEqual(result);
    }
}
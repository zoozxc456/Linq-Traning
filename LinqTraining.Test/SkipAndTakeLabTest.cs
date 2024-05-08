using ExpectedObjects;
using LinqTraining.Data;
using LinqTraining.Labs;

namespace LinqTraining.Test;

[TestFixture]
public class SkipAndTakeLabTest
{
    private readonly SkipAndTakeLab _skipAndTakeLab;

    public SkipAndTakeLabTest()
    {
        _skipAndTakeLab = new SkipAndTakeLab();
    }

    [Test]
    public void Skip2Products()
    {
        var expected = new List<Product>
        {
            new() { Id = 3, Name = "iPhone 15 Pro", Price = 479, ReleaseDate = new DateOnly(2023, 10, 1) },
            new() { Id = 4, Name = "iPhone 15 Pro Max", Price = 499, ReleaseDate = new DateOnly(2023, 10, 1) },
            new() { Id = 5, Name = "iPhone 14", Price = 299, ReleaseDate = new DateOnly(2022, 8, 1) },
            new() { Id = 6, Name = "iPhone 14 Plus", Price = 319, ReleaseDate = new DateOnly(2022, 8, 1) },
            new() { Id = 7, Name = "iPhone 14 Pro", Price = 359, ReleaseDate = new DateOnly(2022, 10, 1) },
            new() { Id = 8, Name = "iPhone 14 Pro Max", Price = 379, ReleaseDate = new DateOnly(2022, 10, 1) }
        }.ToExpectedObject();

        var result = _skipAndTakeLab.Skip2Products();

        expected.ShouldEqual(result);
    }

    [Test]
    public void Take5Products()
    {
        var expected = new List<Product>
        {
            new() { Id = 1, Name = "iPhone 15", Price = 399, ReleaseDate = new DateOnly(2023, 10, 1) },
            new() { Id = 2, Name = "iPhone 15 Plus", Price = 419, ReleaseDate = new DateOnly(2023, 10, 1) },
            new() { Id = 3, Name = "iPhone 15 Pro", Price = 479, ReleaseDate = new DateOnly(2023, 10, 1) },
            new() { Id = 4, Name = "iPhone 15 Pro Max", Price = 499, ReleaseDate = new DateOnly(2023, 10, 1) },
            new() { Id = 5, Name = "iPhone 14", Price = 299, ReleaseDate = new DateOnly(2022, 8, 1) }
        }.ToExpectedObject();

        var result = _skipAndTakeLab.Take5Products();

        expected.ShouldEqual(result);
    }

    [Test]
    public void Skip2ThenTake5Products()
    {
        var expected = new List<Product>
        {
            new() { Id = 3, Name = "iPhone 15 Pro", Price = 479, ReleaseDate = new DateOnly(2023, 10, 1) },
            new() { Id = 4, Name = "iPhone 15 Pro Max", Price = 499, ReleaseDate = new DateOnly(2023, 10, 1) },
            new() { Id = 5, Name = "iPhone 14", Price = 299, ReleaseDate = new DateOnly(2022, 8, 1) },
            new() { Id = 6, Name = "iPhone 14 Plus", Price = 319, ReleaseDate = new DateOnly(2022, 8, 1) },
            new() { Id = 7, Name = "iPhone 14 Pro", Price = 359, ReleaseDate = new DateOnly(2022, 10, 1) }
        }.ToExpectedObject();

        var result = _skipAndTakeLab.Skip2ThenTake5Products();

        expected.ShouldEqual(result);
    }
}
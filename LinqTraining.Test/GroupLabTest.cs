using ExpectedObjects;
using LinqTraining.Data;
using LinqTraining.Labs;

namespace LinqTraining.Test;

[TestFixture]
public class GroupLabTest
{
    private readonly GroupLab _groupLab;

    public GroupLabTest()
    {
        _groupLab = new GroupLab();
    }

    [Test]
    public void GroupByReleaseDate()
    {

        var expected = new Dictionary<DateOnly, int>
        {
            { new DateOnly(2022, 8, 1),2},
            { new DateOnly(2022, 10, 1),2},
            { new DateOnly(2023, 10, 1),4}
        }.ToExpectedObject();

        var result = _groupLab.GroupByReleaseDate().ToDictionary(x => x.Key, x => x.Count());
        expected.ShouldEqual(result);
    }

    [Test]
    public void GroupByReleaseDateAndPrice()
    {
        var expected = new List<string>
        {
            "2023-10-01-399",
            "2023-10-01-419",
            "2023-10-01-479",
            "2023-10-01-499",
            "2022-08-01-299",
            "2022-08-01-319",
            "2022-10-01-359",
            "2022-10-01-379"
        }.ToExpectedObject();

        var result = _groupLab.GroupByReleaseDateAndPrice().Select(x=>$"{x.Key.ReleaseDate.ToString("yyyy-MM-dd")}-{x.Key.Price}").ToList();

        expected.ShouldEqual(result);
    }
}
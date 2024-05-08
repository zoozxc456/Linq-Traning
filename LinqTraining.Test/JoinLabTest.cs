using ExpectedObjects;
using LinqTraining.Labs;

namespace LinqTraining.Test;

[TestFixture]
public class JoinLabTest
{
    private readonly JoinLab _joinLab;

    public JoinLabTest()
    {
        _joinLab = new JoinLab();
    }

    [Test]
    public void GetBuyersByTotalHigherThen500()
    {
        var expected = new List<string> { "Tim", "Tracy", "Tina", "Ben" }.ToExpectedObject();

        var result = _joinLab.GetBuyersByTotalHigherThen500();

        expected.ShouldEqual(result);
    }

    [Test]
    public void GetBuyersInWhichGroup()
    {
        var expected = new List<string> { "Tim in Normal", "Tracy in VIP", "Mary in Normal", "Tina in Normal", "Jason in Normal", "Ben in Normal" }.ToExpectedObject();

        var result = _joinLab.GetBuyersInWhichGroup();

        expected.ShouldEqual(result);
    }
}

using NUnit.Framework;

namespace FindThePivotInteger;

[TestFixture, Parallelizable]
public class UnitTests
{
    private static IEnumerable<TestCaseData> Cases()
    {
        yield return new TestCaseData(8).Returns(6);
        yield return new TestCaseData(1).Returns(1);
        yield return new TestCaseData(4).Returns(-1);
    }

    [TestCaseSource(nameof(Cases))]
    public int ReturnsPivotInteger(int n)
    {
        return Solution.PivotInteger(n);
    }
}
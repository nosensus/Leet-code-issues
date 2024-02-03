using NUnit.Framework;

namespace KidsWithTheGreatestNumberOfCandies;

[TestFixture, Parallelizable]
public class UnitTest
{
    private static IEnumerable<TestCaseData> Cases()
    {
        yield return new TestCaseData(new[] {2, 3, 5, 1, 3}, 3).Returns(new[] {true, true, true, false, true});
        yield return new TestCaseData(new[] {4, 2, 1, 1, 2}, 1).Returns(new[] {true, false, false, false, false});
        yield return new TestCaseData(new[] {12, 1, 12}, 10).Returns(new[] {true, false, true});
    }

    [TestCaseSource(nameof(Cases))]
    public static IList<bool> KidsWithCandies_DenotingNumberExtraCandies_ReturnsBooleanArray(
        int[] candies,
        int extraCandies)
    {
        return new Solution().KidsWithCandies(candies, extraCandies);
    }
}
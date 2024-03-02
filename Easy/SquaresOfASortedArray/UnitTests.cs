using NUnit.Framework;

namespace SquaresOfASortedArray;

[TestFixture, Parallelizable]
public class UnitTests
{
    private static IEnumerable<TestCaseData> Cases()
    {
        yield return new TestCaseData(new object?[] {new int[] {-4, -1, 0, 3, 10}})
            .Returns(new int[] {0, 1, 9, 16, 100});
        yield return new TestCaseData(new object?[] {new int[] {-7, -3, 2, 3, 11}})
            .Returns(new int[] {4, 9, 9, 49, 121});
    }

    [TestCaseSource(nameof(Cases))]
    public int[] ReturnsSquaresOfEachNumberInAnArraySortedInNonDecreasingOrder(int[] nums)
    {
        return new Solution().SortedSquares(nums);
    }
}
using NUnit.Framework;

namespace MissingNumber;

[TestFixture, Parallelizable]
public class UnitTest
{
    private static IEnumerable<TestCaseData> Cases()
    {
        yield return new TestCaseData(new object?[] {new[] {0, 1, 3, 4}}).Returns(2);
        yield return new TestCaseData(new object?[] {new[] {3, 0, 1}}).Returns(2);
        yield return new TestCaseData(new object?[] {new[] {0, 1}}).Returns(2);
        yield return new TestCaseData(new object?[] {new[] {9, 6, 4, 2, 3, 5, 7, 0, 1}}).Returns(8);
        yield return new TestCaseData(new object?[] {new[] {1}}).Returns(0);
        yield return new TestCaseData(new object?[] {new[] {1, 2}}).Returns(0);
    }

    [TestCaseSource(nameof(Cases))]
    public int MissingNumber_FindMissingNumberInDistictNumberArray_ReturnsNumber(int[] nums)
    {
        return new Solution().MissingNumber(nums);
    }
}
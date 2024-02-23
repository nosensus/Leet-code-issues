using NUnit.Framework;

namespace MaximumAverageSubarrayI;

[TestFixture, Parallelizable]
public class UnitTest
{
    private static IEnumerable<TestCaseData> Cases()
    {
        yield return new TestCaseData(new[] {1, 12, -5, -6, 50, 3}, 4).Returns(12.75000);
        yield return new TestCaseData(new[] {5}, 1).Returns(5.00000);
        yield return new TestCaseData(new[] {-1}, 1).Returns(-1.00000);
    }

    [TestCaseSource(nameof(Cases))]
    public double CalculateMaxAverageValueReturnThisValueFindedSubarrayWhoseLengthIsEqual(int[] nums, int k)
    {
        return new Solution().FindMaxAverage(nums, k);
    }
}
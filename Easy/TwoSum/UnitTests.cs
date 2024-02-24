using NUnit.Framework;

namespace TwoSum;

[TestFixture, Parallelizable]
public class UnitTests
{
    private static IEnumerable<TestCaseData> Cases()
    {
        yield return new TestCaseData(new int[] {2, 7, 11, 15}, 9).Returns(new int[] {0, 1});
        yield return new TestCaseData(new int[] {3, 2, 4}, 6).Returns(new int[] {1, 2});
        yield return new TestCaseData(new int[] {3, 3}, 6).Returns(new int[] {0, 1});
        yield return new TestCaseData(new int[] {-1, -2, -3, -4, -5}, -8).Returns(new int[] {2, 4});
    }

    [TestCaseSource(nameof(Cases))]
    public int[] ReturnsTwoNumbersThatTheyAddUp(int[] nums, int target)
    {
        return new Solution().TwoSum(nums, target);
    }
}
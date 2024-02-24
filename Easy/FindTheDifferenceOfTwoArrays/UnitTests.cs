using NUnit.Framework;

namespace FindTheDifferenceOfTwoArrays;

[TestFixture, Parallelizable]
public class UnitTests
{
    private static IEnumerable<TestCaseData> Cases()
    {
        yield return new TestCaseData(new[] {1, 2, 3}, new[] {2, 4, 6})
            .Returns(new List<IList<int>> {new List<int> {1, 3}, new List<int> {4, 6}});
        yield return new TestCaseData(new[] {1, 2, 3, 3}, new[] {1, 1, 2, 2})
            .Returns(new List<IList<int>> {new List<int> {3}, new List<int>()});
    }

    [TestCaseSource(nameof(Cases))]
    public IList<IList<int>> ReturnsDistinctIntegersWhichAreNotPresentInTheNearbyArray(int[] nums1, int[] nums2)
    {
        return new Solution().FindDifference(nums1, nums2);
    }
}
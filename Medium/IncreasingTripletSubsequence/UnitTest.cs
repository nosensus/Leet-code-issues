using NUnit.Framework;

namespace ProductOfArrayExceptSelf;

[TestFixture]
[Parallelizable]
public class UnitTest
{
    private static IEnumerable<TestCaseData> Cases()
    {
        yield return new TestCaseData(new object[] {new[] {1, 2, 3, 4, 5}}).Returns(true);
        yield return new TestCaseData(new object[] {new[] {5, 4, 3, 2, 1}}).Returns(false);
        yield return new TestCaseData(new object[] {new[] {2, 1, 5, 0, 4, 6}}).Returns(true);
        yield return new TestCaseData(new object[] {new[] {20, 100, 10, 12, 5, 13}}).Returns(true);
    }

    [TestCaseSource(nameof(Cases))]
    public bool ReturnsArrayEqualOfAllElements(int[] nums)
    {
        return new Solution().IncreasingTriplet(nums);
    }
}
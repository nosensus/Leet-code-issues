using NUnit.Framework;

namespace ProductOfArrayExceptSelf;

[TestFixture]
[Parallelizable]
public class UnitTest
{
    private static IEnumerable<TestCaseData> Cases()
    {
        yield return new TestCaseData(new object[] {new[] {2, 1, 3, 2, 1}}).Returns(new[] {6, 12, 4, 6, 12});
        yield return new TestCaseData(new object[] {new[] {1, 2, 3, 4}}).Returns(new[] {24, 12, 8, 6});
        yield return new TestCaseData(new object[] {new[] {-1, 1, 0, -3, 3}}).Returns(new[] {0, 0, 9, 0, 0});
    }

    [TestCaseSource(nameof(Cases))]
    public int[] ReturnsArrayEqualOfAllElements(int[] nums)
    {
        return new Solution().ProductExceptSelf(nums);
    }
}
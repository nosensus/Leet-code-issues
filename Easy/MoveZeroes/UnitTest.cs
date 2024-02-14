using NUnit.Framework;

namespace MoveZeroes;

[TestFixture, Parallelizable]
public class UnitTest
{
    private static IEnumerable<TestCaseData> Cases()
    {
        yield return new TestCaseData(new object[] {new [] {0, 1, 0, 3, 12}}).Returns(new[] {1, 3, 12, 0, 0});
        yield return new TestCaseData(new object[] {new [] {0}}).Returns(new[] {0});
    }

    [TestCaseSource(nameof(Cases))]
    public static int[] MoveZeroes_MoveZeroesToTheEndOfArray_ReturnArray(int[] nums)
    {
        return new Solution().MoveZeroes(nums);
    } 
}
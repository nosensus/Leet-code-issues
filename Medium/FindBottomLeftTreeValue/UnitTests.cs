using NUnit.Framework;

namespace FindBottomLeftTreeValue;

[TestFixture, Parallelizable]
public class UnitTests
{
    private static IEnumerable<TestCaseData> Cases()
    {
        yield return new TestCaseData(TreeNodeBuilder.Builder([2, 1, 3])).Returns(1);
        yield return new TestCaseData(TreeNodeBuilder.Builder([1, 2, 3, 4, null, 5, 6, null, null, 7])).Returns(7);
    }

    [TestCaseSource(nameof(Cases))]
    public int ReturnsLeftMostValueInTheLastRowOfTheTree(TreeNode nodes)
    {
        return new Solution().FindBottomLeftValue(nodes);
    }
}
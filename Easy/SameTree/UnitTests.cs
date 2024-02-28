using NUnit.Framework;

namespace SameTree;

[TestFixture, Parallelizable]
public class UnitTests
{
    private static IEnumerable<TestCaseData> Cases()
    {
        yield return new TestCaseData(TreeNodeCreator.Create([1, 2, 3]), TreeNodeCreator.Create([1, 2, 3]))
            .Returns(true);
        yield return new TestCaseData(TreeNodeCreator.Create([1, 2]), TreeNodeCreator.Create([1, null, 2]))
            .Returns(false);
        yield return new TestCaseData(TreeNodeCreator.Create([1, 2, 1]), TreeNodeCreator.Create([1, 1, 2]))
            .Returns(false);
    }

    [TestCaseSource(nameof(Cases))]
    public bool CompareTreeNodesAndReturnsBooleanValue(TreeNode p, TreeNode q)
    {
        return new Solution().IsSameTree(p, q);
    }
}
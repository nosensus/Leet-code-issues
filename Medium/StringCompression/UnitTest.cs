using NUnit.Framework;

namespace ProductOfArrayExceptSelf;

[TestFixture]
[Parallelizable]
public class UnitTest
{
    private static IEnumerable<TestCaseData> Cases()
    {
        yield return new TestCaseData(new object[] {new[] {"a", "a", "b", "b", "c", "c", "c"}})
            .Returns(new object[] {6, new[] {"a", "2", "b", "2", "c", "3"}});
        yield return new TestCaseData(new object[] {new[] {"a"}})
            .Returns(new object[] {1, new[] {"a"}});
        yield return new TestCaseData(new object[]
                {new[] {"a", "b", "b", "b", "b", "b", "b", "b", "b", "b", "b", "b", "b"}})
            .Returns(new object[] {4, new[] {"a", "b", "1", "2"}});
    }

    [TestCaseSource(nameof(Cases))]
    public int ReturnsCompressedString(char[] chars)
    {
        return new Solution().Compress(chars);
    }
}
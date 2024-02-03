using NUnit.Framework;

namespace MergeStringsAlternately;

[TestFixture, Parallelizable]
internal class UnitTest
{
    private static IEnumerable<TestCaseData> Cases()
    {
        yield return new TestCaseData("abc", "pqr").Returns("apbqcr");
        yield return new TestCaseData("ab", "pqrs").Returns("apbqrs");
        yield return new TestCaseData("abcd", "pq").Returns("apbqcd");
    }

    [TestCaseSource(nameof(Cases))]
    public static string ReturnsMergeStrings(string str1, string str2)
    {
        return new Solution().MergeAlternately(str1, str2);
    }
}

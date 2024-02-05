using NUnit.Framework;

namespace ReverseWordsInAString;

[TestFixture, Parallelizable]
public class UnitTest
{
    private static IEnumerable<TestCaseData> Cases()
    {
        yield return new TestCaseData("the sky is blue").Returns("blue is sky the");
        yield return new TestCaseData("  hello world  ").Returns("world hello");
        yield return new TestCaseData("a good   example").Returns("example good a");
    }

    [TestCaseSource(nameof(Cases))]
    public string ReturnsStringWordsReverseOrderConcatWithSingleSpace(string str)
    {
        return new Solution().ReverseWords(str);
    }
}
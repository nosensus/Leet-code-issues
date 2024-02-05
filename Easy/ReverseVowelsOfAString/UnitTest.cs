using NUnit.Framework;

namespace ReverseVowelsOfAString;


[TestFixture, Parallelizable]
internal class UnitTest
{
    private static IEnumerable<TestCaseData> Cases()
    {
        yield return new TestCaseData("hello").Returns("holle");
        yield return new TestCaseData("leetcode").Returns("leotcede");
        yield return new TestCaseData("laetcudi").Returns("liutceda");
    }

    [TestCaseSource(nameof(Cases))]
    public static string ReverseVowelsString_ReverseOnlyVowelsLetters_ReturnString(string str)
    {
        return new Solution().ReverseVowels(str);
    }
}
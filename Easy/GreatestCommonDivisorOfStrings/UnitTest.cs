using NUnit.Framework;

namespace GreatestCommonDivisorOfStrings;

[TestFixture, Parallelizable]
internal class UnitTest
{
    private static IEnumerable<TestCaseData> Cases()
    {
        yield return new TestCaseData("ABCABC", "ABC").Returns("ABC");
        yield return new TestCaseData("ABABAB", "ABAB").Returns("AB");
        yield return new TestCaseData("LEET", "CODE").Returns("");
        yield return new TestCaseData("ABCDER", "ABC").Returns("");
    }

    [TestCaseSource(nameof(Cases))]
    public static string ReturnsGCD(string str1, string str2)
    {
        return new Solution().GcdOfStrings(str1, str2);
    }
}
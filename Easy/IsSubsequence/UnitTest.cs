using NUnit.Framework;

namespace IsSubsequence;

[TestFixture, Parallelizable]
public class UnitTest
{
    private static IEnumerable<TestCaseData> Cases()
    {
        yield return new TestCaseData("abc", "ahbgdc").Returns(true);
        yield return new TestCaseData("axc", "ahbgdc").Returns(false);
        yield return new TestCaseData("acb", "ahbgdc").Returns(false);
        yield return new TestCaseData("aaaaaa", "bbaaaa").Returns(false);
        yield return new TestCaseData("bb", "ahbgdc").Returns(false);
        yield return new TestCaseData("", "ahbgdc").Returns(true);
        yield return new TestCaseData("b", "abc").Returns(true);
    }

    [TestCaseSource(nameof(Cases))]
    public bool ReturnsBoolWhenGivenSubsequenceIsOfString(string s, string t)
    {
        return new Solution().IsSubsequence(s, t);
    }
}
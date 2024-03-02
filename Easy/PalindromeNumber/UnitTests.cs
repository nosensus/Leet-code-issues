using NUnit.Framework;

namespace PalindromeNumber;

[TestFixture, Parallelizable]
public class UnitTests
{
    private static IEnumerable<TestCaseData> Cases()
    {
        yield return new TestCaseData(121).Returns(true);
        yield return new TestCaseData(-121).Returns(false);
        yield return new TestCaseData(10).Returns(false);
    }

    [TestCaseSource(nameof(Cases))]
    public bool CheckNumberOnPalindrome(int x)
    {
        return new Solution().IsPalindrome(x);
    }
}
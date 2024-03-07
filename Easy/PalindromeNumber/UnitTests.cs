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
        yield return new TestCaseData(0).Returns(true);
        yield return new TestCaseData(1234567899).Returns(false);
        yield return new TestCaseData(-2147483648).Returns(false);
    }

    [TestCaseSource(nameof(Cases))]
    public bool CheckNumberOnPalindrome(int x)
    {
        return new Solution().IsPalindrome(x);
    }
}
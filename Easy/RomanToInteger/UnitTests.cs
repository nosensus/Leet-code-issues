using NUnit.Framework;

namespace RomanToInteger;

[TestFixture, Parallelizable]
public class UnitTests
{
    private static IEnumerable<TestCaseData> Cases()
    {
        yield return new TestCaseData("III").Returns(3);
        yield return new TestCaseData("LVIII").Returns(58);
        yield return new TestCaseData("MCMXCIV").Returns(1994);
    }

    [TestCaseSource(nameof(Cases))]
    public static int ReturnsConvertedRomanNumeralToInteger(string s)
    {
        return new Solution().RomanToInt(s);
    }
}
using NUnit.Framework;

namespace FindTheHighestAltitude;

[TestFixture, Parallelizable]
public class UnitTest
{
    private static IEnumerable<TestCaseData> Cases()
    {
        yield return new TestCaseData(new object?[] {new[] {-5, 1, 5, 0, -7}}).Returns(1);
        yield return new TestCaseData(new object?[] {new[] {-4,-3,-2,-1,4,3,2}}).Returns(0);
    }

    [TestCaseSource(nameof(Cases))]
    public static int ReturnHighestAltitudeInGivenArray(int[] gain)
    {
        return new Solution().LargestAltitude(gain);
    }
}
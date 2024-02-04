using NUnit.Framework;

namespace CanPlaceFlowers;

[TestFixture, Parallelizable]
public class UnitTest
{
    private static IEnumerable<TestCaseData> Cases()
    {
        yield return new TestCaseData(new[] {1, 0, 0, 0, 1}, 1).Returns(true);
        yield return new TestCaseData(new[] {1, 0, 0, 0, 1}, 2).Returns(false);
        yield return new TestCaseData(new[] {1, 0, 1, 0, 1, 0, 1}, 1).Returns(false);
        yield return new TestCaseData(new[] {1, 0, 1, 0, 1, 0, 1}, 0).Returns(true);
        yield return new TestCaseData(new[] {0, 0, 1, 0, 0}, 2).Returns(true);
        yield return new TestCaseData(new[] {0, 0, 1, 0, 0}, 1).Returns(true);
        yield return new TestCaseData(new[] {1, 0, 0, 0, 0, 1}, 2).Returns(false);
        yield return new TestCaseData(new[] {0}, 1).Returns(true);
        yield return new TestCaseData(new[] {1, 0, 0}, 1).Returns(true);
        yield return new TestCaseData(new[] {1, 0, 0, 0, 0, 0, 0, 0, 1}, 3).Returns(true);
        yield return new TestCaseData(new[] {0, 1, 0}, 1).Returns(false);
    }

    [TestCaseSource(nameof(Cases))]
    public static bool CanPlaceFlowers_NewFlowersCanBePlantedWithoutViolating_ReturnsBooleanResult(
        int[] flowerbed,
        int newFlowers)
    {
        return new Solution().CanPlaceFlowers(flowerbed, newFlowers);
    }
}
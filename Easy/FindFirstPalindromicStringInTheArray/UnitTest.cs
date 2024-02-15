using NUnit.Framework;

namespace FindFirstPalindromicStringInTheArray;

[TestFixture, Parallelizable]
public class UnitTest
{
    private static IEnumerable<TestCaseData> Cases()
    {
        yield return new TestCaseData(new object[] {new[] {"abc", "car", "ada", "racecar", "cool"}}).Returns("ada");
        yield return new TestCaseData(new object[] {new[] {"notapalindrome", "racecar"}}).Returns("racecar");
        yield return new TestCaseData(new object[] {new[] {"def", "ghi"}}).Returns("");
        yield return new TestCaseData(new object[] {new[] {"xngla", "e", "itrn", "y", "s", "pfp", "rfd"}})
            .Returns("e");
        yield return new TestCaseData(new object[]
        {
            new[]
            {
                "knywrurkwbrtpalvuuzbczcwzpdqibcwwyflwiddixemsrwblupyerjgvcpavdjfhmujitcsmdbvhxw",
                "ovkeowhqvwlndtpxdnimgietvjsqydbuuwmxkfxxgn", 
                "damomwtjugmsrfyvytaheg", 
                "bngqatscosdakdwjz",
                "jwzcowuantgqlzjrzgpapcugxvviltrhmcwijtpqapmxjfcilrsmsbeffphcxmaozlczncoxxjmuqijhidxqinhywrtah",
                "ujvoejixvaioikkwzxgtmkchckrigfejjpheiiehpjjefgirkchckmtgxzwkkioiavxijeovju",
                "kacjvcouuigbhydrryaperxvjetwsycmnlkxujaqngjhhotqskclquklxsozfryfxwiksstmropcdvhgsnosgvltqo",
                "qrbsdxxolwzmyltproznfgyydxkkejwdiwpvfzvjoxqvwguoerhclytzvolymbxummwsoqtttyttik", 
                "tkekt",
                "esrshrlfoihhjrouleucwpeubygivoatrfraphgwpvtkanwu",
                "kwzrfelynncvsrwvaukiinhjdydmlimggjldhflygemzwnjizzlsuqwahsufwmwhfjkjpngdfsudyavtogoaqzknpew",
                "sdgpcnvsbzxhyjt"
            }
        }).Returns("ujvoejixvaioikkwzxgtmkchckrigfejjpheiiehpjjefgirkchckmtgxzwkkioiavxijeovju");
        yield return new TestCaseData(new object[]
        {
            new[]
            {
                "cqllrtyhw", "swwisru", "gpzmbders", "wqibjuqvs", "pp", "usewxryy", "ybqfuh", "hqwwqftgyu", "jggmatpk"
            }
        }).Returns("pp");
    }

    [TestCaseSource(nameof(Cases))]
    public static string FindFirstPalindrom_InTheGivenArrayFindPalindrom_ReturnItOrEmptyString(string[] words)
    {
        return new Solution().FirstPalindrome(words);
    }
}
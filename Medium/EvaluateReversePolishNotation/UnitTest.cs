using NUnit.Framework;

namespace EvaluateReversePolishNotation;

[TestFixture, Parallelizable]
public class UnitTest
{
    private static IEnumerable<TestCaseData> Cases() {
        yield return new TestCaseData(new object[] { new[] { "2", "1", "+", "3", "*" } }).Returns(9);
        yield return new TestCaseData(new object[] { new[] { "4", "13", "5", "/", "+" } }).Returns(6);
        yield return new TestCaseData(new object[] { new[] { "10","6","9","3","+","-11","*","/","*","17","+","5","+" } }).Returns(22);
    }

    [TestCaseSource(nameof(Cases))]
    public static int ReversePolishNotation_RepresentsValueOfTheExpression_ReturnsInteger(string[] tokens)
    {
        return new Solution().EvalRPN(tokens);
    }
}
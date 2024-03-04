public class Solution {
    public bool IsPalindrome(int x)
    {
        var number = x.ToString();
        var reverse = String.Concat(number.Reverse());
        return number == reverse;
    }
}
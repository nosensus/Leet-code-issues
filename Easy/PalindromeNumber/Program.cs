public class Solution
{
    // Follow up: Could you solve it without converting the integer to a string?
    public bool IsPalindrome(int x)
    {
        var numToString = x.ToString();
        int leftPointer = 0;
        int rightPointer = numToString.Length - 1;

        while (leftPointer <= rightPointer)
        {
            if (numToString[leftPointer] == numToString[rightPointer])
            {
                leftPointer++;
                rightPointer--;
            }
            else
            {
                return false;
            }
        }

        return true;
    }

    // Direct solution
    // public bool IsPalindrome(int x)
    // {
    //     var number = x.ToString();
    //     var reverse = String.Concat(number.Reverse());
    //     return number == reverse;
    // }
}
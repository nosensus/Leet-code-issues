public class Solution
{
    // 3. Follow up: Could you solve it without converting the integer to a string?
    public bool IsPalindrome(int x)
    {
        if (x == 0) return true;
        int x2 = SplitNumberToArrayInt(x);
        return x == x2;
    }

    public static int SplitNumberToArrayInt(int x)
    {
        List<int> numArray = new List<int>();
        if (x < 0)
        {
            x *= -1;
        }

        while (x != 0)
        {
            numArray.Add(x % 10);
            x /= 10;
        }
        
        
        

        return int.Parse(string.Join("", numArray));
    }


    // 2. Two pointers but working with a string
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

    // 1. Direct solution
    // public bool IsPalindrome(int x)
    // {
    //     var number = x.ToString();
    //     var reverse = String.Concat(number.Reverse());
    //     return number == reverse;
    // }
}
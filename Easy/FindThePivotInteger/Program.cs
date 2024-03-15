public class Solution
{
    public static int PivotInteger(int n)
    {
        if (n == 1) return 1;
    
        int sum = n * (n + 1) / 2;
        int rightSum = n;
        int leftSum = sum;
    
        for (int i = n; i > 1; i--)
        {
            rightSum += i - 1;
            leftSum -= i;
            if (rightSum == leftSum)
            {
                return i - 1;
            }
        }
    
        return -1;
    }
    
    // public static int PivotInteger(int n) {
    //     var t = Math.Sqrt(n * (n + 1) / 2); 
    //     int r = (int)t;
    //     return t == r ? r : -1;
    // }
}
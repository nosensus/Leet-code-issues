public class Solution
{
    public bool IncreasingTriplet(int[] nums)
    {
        int minVal = int.MaxValue; 
        int maxVal = int.MaxValue;

        foreach (int n in nums)
        {
            if (n <= minVal)
                minVal = n;
            else if (n <= maxVal)
                maxVal = n;
            else
                return true;
        }

        return false;
    
    }
}
﻿public class Solution
{
    public bool IncreasingTriplet(int[] nums)
    {
<<<<<<< HEAD
        int start = nums[0];
        int end = 0;
        for (int i = 1; i <= nums.Length - 2; i++)
        {
            end = nums[i + 1];
            if (start < nums[i] && nums[i] < end) return true;

            start = nums[i];
        }

        return false;
=======
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
    
>>>>>>> 81a9b9454ddd590349300c9d96f0790d1e96b8c9
    }
}
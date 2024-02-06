public class Solution
{
    public bool IncreasingTriplet(int[] nums)
    {
        int start = nums[0];
        int end = 0;
        for (int i = 1; i <= nums.Length - 2; i++)
        {
            end = nums[i + 1];
            if (start < nums[i] && nums[i] < end) return true;

            start = nums[i];
        }

        return false;
    }
}
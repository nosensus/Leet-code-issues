public class Solution
{
    public int[] MoveZeroes(int[] nums)
    {
        int leftPointer = 0;
        int rightPointer = 0;

        for (int i = 0; i <= nums.Length - 1; i++)
        {
            if (nums[i] != 0)
            {
                int temp = nums[i];
                nums[i] = nums[leftPointer];
                nums[leftPointer] = temp;
                
                rightPointer ++;
                leftPointer ++;
                continue;
            }

            rightPointer++;
        }
        
        return nums;
    }
}
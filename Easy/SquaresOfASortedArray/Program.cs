public class Solution
{
    // Two pointers
    public static int[] SortedSquares(int[] nums)
    {
        int leftPointer = 0;
        int rightPointer = nums.Length - 1;
        int[] result = new int[nums.Length];
        int index = nums.Length - 1;

        while (leftPointer <= rightPointer)
        {
            int left = nums[leftPointer] * nums[leftPointer];
            int right = nums[rightPointer] * nums[rightPointer];
            if (left > right)
            {
                result[index] = left;
                index--;
                leftPointer++;
                continue;
            }

            result[index] = right;
            index--;
            rightPointer--;
        }

        return result;
    }

    // used native methods
    // public int[] SortedSquares(int[] nums)
    // {
    //     for (int i = 0; i <= nums.Length - 1; i++)
    //     {
    //         nums[i] *= nums[i];
    //     }
    //
    //     Array.Sort(nums);
    //
    //     return nums;
    // }
}
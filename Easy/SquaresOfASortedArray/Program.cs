public class Solution
{
    // Two pointers
    public static int[] SortedSquares(int[] nums)
    {
        int leftPointer = 0;
        int rightPointer = nums.Length - 1;
        List<int> result = new List<int>();

        while (leftPointer <= rightPointer)
        {
            int left = nums[leftPointer] * nums[leftPointer];
            int right = nums[rightPointer] * nums[rightPointer];
            if (left > right)
            {
                result.Insert(0, left);
                leftPointer++;
                continue;
            }

            result.Insert(0, right);
            rightPointer--;
        }

        return result.ToArray();
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
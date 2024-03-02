public class Solution {
    public int[] SortedSquares(int[] nums)
    {
        int[] sortedSquaresNumberArray = {};

        int leftPointer = 0;
        int rightPointer = 0;
        for (int i = 1; i <= nums.Length - 1; i++)
        {
            int leftValue = nums[leftPointer] * nums[leftPointer];
            int rightValue = nums[i] * nums[i];
            if (leftValue > rightValue)
            {
                int temp = rightValue;
                nums[i] = leftValue;
                nums[leftPointer] = rightValue;
                leftPointer++;
                rightPointer++;

                continue;
            }

            rightPointer++;
        }

        return sortedSquaresNumberArray;
    }
}
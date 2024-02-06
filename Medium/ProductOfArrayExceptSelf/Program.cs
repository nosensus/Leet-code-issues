using System.Collections;

public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] result = new int[nums.Length];

        int temp = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            result[i] = temp;
            temp *= nums[i];
        }

        temp = nums[^1];
        for (int i = result.Length - 2; i > 0; i--)
        {
            result[i] *= temp;
            temp *= nums[i];
        }

        result[0] = temp;
        return result;
    }
}
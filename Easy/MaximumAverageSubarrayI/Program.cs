using System.Collections;

public class Solution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        double result = -1.7976931348623157E+308;
        for (int i = 0; i <= nums.Length - 1;)
        {
            int current = i;
            int sum = 0;
            int windowSize = k;
            if (nums.Length - i < k) break;

            while (windowSize != 0)
            {
                sum += nums[current];
                current++;
                windowSize--;
            }

            i++;
            var temp = (double) sum / (double) k;
            if (result < temp)
            {
                result = temp;
            }
        }

        return result;
    }
}
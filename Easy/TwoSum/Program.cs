using System.Collections;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        List<int> indexes = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int difference = target - nums[i];
            for (int j = i + 1; j < nums.Length;)
            {
                if (nums[j] == difference)
                {
                    indexes.Add(i);
                    indexes.Add(j);
                    break;
                }

                j++;
            }

            if (indexes.Count > 0)
            {
                break;
            }
        }

        return indexes.ToArray();
    }
}
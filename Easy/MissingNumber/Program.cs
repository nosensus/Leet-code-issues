using Array = System.Array;

/*
    1.Mathematics(sum of n natural number)
    2.Sorting
    3.HashSet
    4.Bit Manipulation

    1.Mathematics (Sum Formula):
    misNum = n(n+1)/2 - sumofELements(nums)   // where n is the last number in the sequence
    Time Complexity: O(n)
    Space Complexity: O(1)
    Calculates the missing number using the sum formula of the first n natural numbers.

    2.Sorting:
    Time Complexity: O(nlogn) (due to sorting) + O(n) (iterating through the array)
    Space Complexity: O(1)
    Sorts the array and then iterates through it to find the missing number.

    3.HashSet:
    Time Complexity: O(n)
    Space Complexity: O(n)
    Uses a HashSet to store the array elements and then iterates through the array to find the missing number.

    4.XOR (Bit Manipulation):
    Time Complexity: O(n)
    Space Complexity: O(1)
    Utilizes XOR operation to find the missing number without requiring extra space.

    All approaches provide different trade-offs in terms of time complexity, space complexity, and implementation simplicity.
*/

// 1.Mathematics (Sum Formula):   Runtime 17.74%  Memory 17.38%
// public class Solution
// {
//     public int MissingNumber(int[] nums)
//     {
//         Array.Sort(nums);
//         int n = nums[nums.Length - 1];
//         
//         if (nums[0] == 1) return 0;
//         
//         int missedNumber = 0;
//         int sum = nums.Sum();
//         
//         missedNumber = n * (n + 1) / 2 - sum;
//         
//         if (missedNumber == 0) return n + 1; // // we take next element if all numbers are in the range [0, n]. n+1 is the missing number in the range since it does not appear in nums. 
//
//         return missedNumber;
//     }
// }

// 3.HashSet:
public class Solution
{
    public int MissingNumber(int[] nums)
    {
        Array.Sort(nums);
        HashSet<int> hashSet = new HashSet<int>(nums);
        for (int i = 0; i <= nums.Length - 1; i++)
        {
            if (!hashSet.Contains(i)) return i;
        }

        return nums[^1] + 1;
    }
}

// 4 XOR  Runtime 42.59%  Memory 58.32%
// public class Solution 
// {
//     public int MissingNumber(int[] nums)
//     {
//         int sum = 0;
//         int n = nums.Length;
//         for (int i = 0; i < n; i++)
//         {
//             sum ^= i ^ nums[i];
//         }
//
//         return sum ^ n;
//     }
// }
public class Solution {
    public int LargestAltitude(int[] gain) {
        int highestAltitude = 0;
        int prefixSum = 0;
        for (int i = 0; i <= gain.Length - 1; i++)
        {
            prefixSum += gain[i];
            if (prefixSum > highestAltitude)
            {
                highestAltitude = prefixSum;
            }
        }

        return highestAltitude;
    }
}
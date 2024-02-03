public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        int maxValue = candies.Max();
        List<bool> result = new List<bool>();
        foreach (int candy in candies)
        {
            result.Add(candy + extraCandies >= maxValue);
        }

        return result;
    }
}

public class Solution
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        if (n == 0 || (flowerbed is [0] && n == 1)) return true;

        for (int i = 0; i < flowerbed.Length; i++)
        {
            if (n == 0)
            {
                break;
            }

            if (flowerbed[i] == 1) continue;

            int prev = i > 0 ? flowerbed[i - 1] : 0;
            int next = i < flowerbed.Length - 1 ? flowerbed[i + 1] : 0;

            if (prev == 0 && next == 0)
            {
                flowerbed[i] = 1;
                n--;
            }
        }

        return n == 0;
    }
}
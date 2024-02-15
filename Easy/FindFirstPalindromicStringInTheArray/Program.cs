public class Solution
{
    public string FirstPalindrome(string[] words)
    {
        string result = "";

        for (int i = 0; i <= words.Length - 1; i++)
        {
            if (IsPalindrom(words[i])) return words[i];
        }

        return result;
    }

    private bool IsPalindrom(string word)
    {
        int start = 0;
        int end = word.Length - 1;

        while (start <= end)
        {
            if (start == end)
            {
                return true;
            }

            if (word[start] != word[end])
            {
                return false;
            }

            start++;
            end--;
        }

        return true;
    }
}
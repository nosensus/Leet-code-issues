public class SolutionReverse
{
    public string FirstPalindromeThroughReverse(string[] words)
    {
        string result = "";

        for (int i = 0; i <= words.Length - 1; i++)
        {
            string word = words[i];
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);

            string reverse = new string(charArray);
            if (word == reverse)
            {
                return word;
            }
        }

        return result;
    }
}
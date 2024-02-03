public class Solution {
    public string MergeAlternately(string word1, string word2) {
        char[] chars1 = word1.ToCharArray();
        char[] chars2 = word2.ToCharArray();

        List<char> result = new List<char>();

        for(int i = 0; i < chars1.Length; i++)
        {
            result.Add(chars1[i]);

            for(int j = chars2.Length-1; j >= i; j--)
            {
                if(j == i)
                {
                    result.Add(chars2[i]);
                }
            }
        }

        if(chars1.Length < chars2.Length)
        {
            for (int i = chars1.Length; i < chars2.Length; i++)
            {
                result.Add(chars2[i]);

            }
        }

        return new string(result.ToArray());
    }
}
public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        int subseqPointer = 0;
        int stringPointer = 0;

        if (s.Length > t.Length) return false;
        if (s.Length == 0) return true;
        
        while (stringPointer <= t.Length - 1 && subseqPointer <= s.Length - 1)
        {
            if (s[subseqPointer] == t[stringPointer])
            {
                subseqPointer++;
                stringPointer++;
            }
            else
            {
                stringPointer++;
            }
        }

        if (subseqPointer == s.Length) return true;

        return false;
    }
}
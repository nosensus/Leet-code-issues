// There are six instances where subtraction is used:
//
// I can be placed before V (5) and X (10) to make 4 and 9. 
// X can be placed before L (50) and C (100) to make 40 and 90. 
// C can be placed before D (500) and M (1000) to make 400 and 900.

public class Solution
{
    public int RomanToInt(string s)
    {
        int convertedInteger = 0;
        var romanToInt = new Dictionary<string, int>()
        {
            {"I", 1},
            {"IV", 4},
            {"V", 5},
            {"IX", 9},
            {"X", 10},
            {"XL", 40},
            {"L", 50},
            {"XC", 90},
            {"C", 100},
            {"CD", 400},
            {"D", 500},
            {"CM", 900},
            {"M", 1000}
        };

        s = s.ToUpper();
        for (int i = 0; i < s.Length; i++)
        {
            string newSrt = s[i].ToString();
            if (i < s.Length - 1)
            {
                if (s[i].ToString() == "I")
                {
                    if (s[i + 1].ToString() == "V" || s[i + 1].ToString() == "X")
                    {
                        newSrt += s[i + 1].ToString();
                        i += 1;
                    }
                }
                else if (s[i].ToString() == "X")
                {
                    if (s[i + 1].ToString() == "L" || s[i + 1].ToString() == "C")
                    {
                        newSrt += s[i + 1].ToString();
                        i += 1;
                    }
                }
                else if (s[i].ToString() == "C")
                {
                    if (s[i + 1].ToString() == "D" || s[i + 1].ToString() == "M")
                    {
                        newSrt += s[i + 1].ToString();
                        i += 1;
                    }
                }
            }

            foreach (KeyValuePair<string, int> entry in romanToInt)
            {
                if (entry.Key == newSrt)
                {
                    convertedInteger += entry.Value;
                }
            }
        }

        return convertedInteger;
    }
}
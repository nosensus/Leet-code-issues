// There are six instances where subtraction is used:
//
// I can be placed before V (5) and X (10) to make 4 and 9. 
// X can be placed before L (50) and C (100) to make 40 and 90. 
// C can be placed before D (500) and M (1000) to make 400 and 900.

public class Solution
{
    readonly Dictionary<char, int> dictionary = new()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };

    public int RomanToInt(string s)
    {
        int convertedInteger = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (i == s.Length - 1)
            {
                convertedInteger += dictionary[s[i]];
                break;
            }

            if (dictionary[s[i]] >= dictionary[s[i + 1]])
            {
                convertedInteger += dictionary[s[i]];
            }
            else
            {
                convertedInteger += dictionary[s[i + 1]] - dictionary[s[i]];
                i++;
            }
        }

        return convertedInteger;
    }


    // First approach
    // readonly Dictionary<string, int> dictionary = new()
    // {
    //     {"I", 1},
    //     {"IV", 4},
    //     {"V", 5},
    //     {"IX", 9},
    //     {"X", 10},
    //     {"XL", 40},
    //     {"L", 50},
    //     {"XC", 90},
    //     {"C", 100},
    //     {"CD", 400},
    //     {"D", 500},
    //     {"CM", 900},
    //     {"M", 1000}
    // };
    //
    // public int RomanToInt(string s)
    // {
    //     int convertedInteger = 0;
    //     
    //     s = s.ToUpper();
    //     for (int i = 0; i < s.Length; i++)
    //     {
    //         string newSrt = s[i].ToString();
    //         if (i < s.Length - 1)
    //         {
    //             if (s[i].ToString() == "I")
    //             {
    //                 if (s[i + 1].ToString() == "V" || s[i + 1].ToString() == "X")
    //                 {
    //                     newSrt += s[i + 1].ToString();
    //                     i += 1;
    //                 }
    //             }
    //             else if (s[i].ToString() == "X")
    //             {
    //                 if (s[i + 1].ToString() == "L" || s[i + 1].ToString() == "C")
    //                 {
    //                     newSrt += s[i + 1].ToString();
    //                     i += 1;
    //                 }
    //             }
    //             else if (s[i].ToString() == "C")
    //             {
    //                 if (s[i + 1].ToString() == "D" || s[i + 1].ToString() == "M")
    //                 {
    //                     newSrt += s[i + 1].ToString();
    //                     i += 1;
    //                 }
    //             }
    //         }
    //
    //         convertedInteger += dictionary[newSrt];
    //     }
    //
    //     return convertedInteger;
    // }
}
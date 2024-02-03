public class Solution
{
    public string GcdOfStrings(string str1, string str2)
    {
        if (!(str1 + str2).Equals(str2 + str1)) return "";
        int str1Length = str1.Length;
        int str2Length = str2.Length;
        int result;

        do
        {
            result = str1Length % str2Length;
            if (result == 0)
            {
                str2 = str2.Substring(0, str2Length);
            }
            str1Length = str2Length;
            str2Length = result;

        }
        while (result != 0);

        return str2;
    }
}
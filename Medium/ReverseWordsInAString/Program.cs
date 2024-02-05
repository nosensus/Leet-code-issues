public class Solution {
    public string ReverseWords(string s)
    {
        string[] stringArray = s.Trim().Split(" ");
        Array.Reverse(stringArray, 0, stringArray.Length);
        string newOne = "";
        foreach (string str in stringArray)
        {
            if (str == "")
            {
                continue;
            }

            newOne += str + " ";
 
        }
        
        return newOne.Trim();
    }
}
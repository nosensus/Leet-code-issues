public class Solution
{
    public string ReverseWords(string s)
    {
        string[] stringArray = s.Trim().Split(" ");
        Stack<string> temp = new Stack<string>();
        foreach (string str in stringArray)
        {
            temp.Push(str);
        }

        string temp2 = "";
        while (temp.Count != 0)
        {
            var element = temp.Pop();
            if (element != "")
            {
                temp2 += element + " ";
            }
        }

        return temp2.Trim();
    }
}
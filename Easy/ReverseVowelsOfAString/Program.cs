public class Solution
{
    // two cursor
    public string ReverseVowels(string s)
    {
        int leftPointer = 0;
        int rightPointer = s.Length - 1;
        char[] charString = s.ToCharArray();
        string vowels = "aAeEiIoOuU";

        while (leftPointer < rightPointer)
        {
            // search vowel from the begin
            while (leftPointer < rightPointer && vowels.IndexOf(charString[leftPointer]) == -1)
            {
                leftPointer++;
            }

            // search vowel from the end
            while (leftPointer < rightPointer && vowels.IndexOf(charString[rightPointer]) == -1)
            {
                rightPointer--;
            }
            
            // swap only vowels them
            (charString[leftPointer], charString[rightPointer]) = (charString[rightPointer], charString[leftPointer]);

            // Move the pointers towards each other
            leftPointer++;
            rightPointer--;
        }

        return new string(charString.ToArray());
    }

    // Very slow
    // Runtime 1198ms Beats 5.08%
    // Memory 220.06MB Beats 5.01%
    
    // public string ReverseVowels(string s)
    // {
    //     char[] vowels = ['a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U'];
    //     List<char> vowelsReverse = new List<char>();
    //     for (int i = s.Length - 1; i >= 0; i--)
    //     {
    //         if (vowels.Select(vowel => s[i] == vowel).Any(b => b))
    //         {
    //             vowelsReverse.Add(s[i]);
    //         }
    //     }
    //
    //     string reverse = "";
    //     int currentVowelsIndex = 0;
    //     foreach (var letter in s)
    //     {
    //         if (letter != 'a'
    //             && letter != 'A'
    //             && letter != 'e'
    //             && letter != 'E'
    //             && letter != 'i'
    //             && letter != 'I'
    //             && letter != 'o'
    //             && letter != 'O'
    //             && letter != 'u'
    //             && letter != 'U')
    //         {
    //             reverse += letter;
    //         }
    //         else
    //         {
    //             reverse += vowelsReverse[currentVowelsIndex];
    //             currentVowelsIndex++;
    //         }
    //     }
    //
    //     return reverse;
    // }
}
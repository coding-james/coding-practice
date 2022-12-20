using System;
using System.Linq;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;
        var vowels = new [] {"a", "e", "i", "o", "u"};
        for (int item = 0; item < str.Length; item++)
        {
            string search = str[item].ToString();
            if (vowels.Any(search.Contains))
            {
                vowelCount++;
            }
        }      
        return vowelCount;
    }
}
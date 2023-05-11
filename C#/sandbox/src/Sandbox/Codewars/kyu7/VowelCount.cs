using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Codewars.kyu7
{
    public class VowelCount
    {
        // CODEWARS: Vowel Count
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;
            var vowels = new[] { "a", "e", "i", "o", "u" };
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
}

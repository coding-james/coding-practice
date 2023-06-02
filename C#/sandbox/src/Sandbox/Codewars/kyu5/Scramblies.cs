using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Codewars.kyu5
{
    public class Scramblies
    {
        // CODEWARS - Scramblies
        // Final Attempt - Using https://www.youtube.com/watch?app=desktop&v=474OLJd2UKg as guidance
        public static bool Scramble(string str1, string str2)
        {
            var countLetterStr1 = str1.GroupBy(ch => ch).ToDictionary(group => group.Key, group => group.Count());
            var countLetterStr2 = str2.GroupBy(ch => ch).ToDictionary(group => group.Key, group => group.Count());
            return countLetterStr2.All(letterCount => countLetterStr1.ContainsKey(letterCount.Key) && letterCount.Value <= countLetterStr1[letterCount.Key]);
        }

        // Original Attempt - Passes Test, but too slow for final Tests
        public static bool ScrambleORIGINAL(string str1, string str2)
        {
            int matches = 0;

            for (int c = 0; c < str2.Length; c++)
            {
                int countStr2 = 0;
                int countStr1 = 0;

                //count how many times c appears in str2
                for (int i = 0; i < str2.Length; i++)
                {
                    if (str2[c] == str2[i])
                        countStr2++;
                }

                //count how many times c appears in str1
                for (int x = 0; x < str1.Length; x++)
                {
                    if (str2[c] == str1[x])
                        countStr1++;
                }

                //if str1 count <= str2 then ok
                if (countStr2 <= countStr1)
                {
                    matches++;
                }
                // System.Console.WriteLine($"{c}: str2 = {countStr2}, str1 = {countStr1}");
            }

            //if matches = str2.length then true, otherwise false
            return matches == str2.Length ? true : false;
        }
    }
}

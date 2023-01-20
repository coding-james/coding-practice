using System;
using System.Linq;

namespace CWars
{
    public class kyu5
    {
        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
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
        // Console.WriteLine($"1: {CWars.kyu5.Scramble("rkqodlw","world")} = true");
        // Console.WriteLine($"2: {CWars.kyu5.Scramble("cedewaraaossoqqyt","codewars")} = true");
        // Console.WriteLine($"3: {CWars.kyu5.Scramble("katas","steak")} = false");
        // Console.WriteLine($"4: {CWars.kyu5.Scramble("scriptjavx","javascript")} = false");
        // Console.WriteLine($"5: {CWars.kyu5.Scramble("scriptingjava","javascript")} = true");
        // Console.WriteLine($"6: {CWars.kyu5.Scramble("scriptsjava","javascripts")} = true");
        // Console.WriteLine($"7: {CWars.kyu5.Scramble("javscripts","javascript")} = false");
        // Console.WriteLine($"8: {CWars.kyu5.Scramble("aabbcamaomsccdd","commas")} = true");
        // Console.WriteLine($"9: {CWars.kyu5.Scramble("commas","commas")} = true");
        // Console.WriteLine($"10: {CWars.kyu5.Scramble("sammoc","commas")} = true");
    }
}
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

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        // CODEWARS - Human Readable Time
        public static string GetReadableTime(int seconds)
        {
            //hours
            decimal hoursR = seconds % 3600;
            int hours = seconds / 3600;

            //mins
            decimal minsR = hoursR % 60;
            int mins = Convert.ToInt32(Math.Floor(hoursR)) / 60;

            //secs
            int sec = Convert.ToInt32(minsR % 60);

            string hoursStr = hours < 10 ? "0" + hours : hours.ToString();
            string minsStr = mins < 10 ? "0" + mins : mins.ToString();
            string secStr = sec < 10 ? "0" + sec : sec.ToString();

            return $"{hoursStr}:{minsStr}:{secStr}";
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        // CODEWARS - Count IP Addresses
        // each number can be between 0 - 255
        public static long IpsBetween(string start, string end)
        {
            return ConvertIPtoValue(end) - ConvertIPtoValue(start);
        }

        public static long ConvertIPtoValue(string ip)
        {
            List<long> ipValue = new List<long>(Array.ConvertAll(ip.Split('.'), long.Parse));
            return (ipValue[0] * 256 * 256 * 256) + (ipValue[1] * 256 * 256) + (ipValue[2] * 256) + ipValue[3];
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        // CODEWARS - Moving Zeros To The End
        public static int[] MoveZeroes(int[] arr)
        {
            int[] result = new int[arr.Length];
            int i = 0;
            int zeroCount = 0;
            foreach (int a in arr)
            {
                if (a != 0)
                {
                    result[i] = a;
                    i++;
                }
                else 
                { 
                    zeroCount++; 
                }
            }

            for (int n = 1; n <= zeroCount; n++)
            {
                result[i] = 0;
                i++;
            }

            return result;
        }
    }
}
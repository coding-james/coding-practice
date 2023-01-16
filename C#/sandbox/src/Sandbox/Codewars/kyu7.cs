using System;
using System.Linq;
using System.Collections.Generic;

namespace CWars
{
    public class kyu7
    {
        // CODEWARS: Disemvowel Trolls
        public static string Disemvowel(string str)
        {
            if (str.Length > 0)
            {
                return str = str.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "").Replace("A", "").Replace("E", "").Replace("I", "").Replace("O", "").Replace("U", "");
            }
            else
            {
                return str;
            }
        }
        // Console.WriteLine(CWars.kyu7.Disemvowel("This website is for losers LOL!"));
        // Console.WriteLine(CWars.kyu7.Disemvowel("No offense but,\nYour writing is among the worst I've ever read"));
        // Console.WriteLine(CWars.kyu7.Disemvowel("What are you, a communist?"));


        // CODEWARS - Find the divisors!
        public static int[] Divisors(int n)
        {
            List<int> result = new List<int>();

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    result.Add(i);
                }
            }

            if (result.Count != 0)
            {
                int[] resultArray = new int[result.Count];

                for (int index = 0; index < result.Count; index++)
                {
                    resultArray[index] = result[index];
                }
                return resultArray;
            }
            else
            {
                return null;
            }
        }
        // Console.WriteLine(CWars.kyu7.Divisors(8));


        // CODEWARS - You're a square!
        public static bool IsSquare(int n)
        {
            if (n >= 0)
            {
                int sr = (int)Math.Sqrt(n);
                return (sr * sr == n);
            }
            return false;
        }
        // Console.WriteLine($"Answer: {CWars.kyu7.IsSquare(-1)} Expected: false");
        // Console.WriteLine($"Answer: {CWars.kyu7.IsSquare(0)} Expected: true");
        // Console.WriteLine($"Answer: {CWars.kyu7.IsSquare(3)} Expected: false");
        // Console.WriteLine($"Answer: {CWars.kyu7.IsSquare(4)} Expected: true");
        // Console.WriteLine($"Answer: {CWars.kyu7.IsSquare(25)} Expected: true");
        // Console.WriteLine($"Answer: {CWars.kyu7.IsSquare(26)} Expected: false");
        // Console.WriteLine($"Answer: {CWars.kyu7.IsSquare(605493)} Expected: false");


        // CODEWARS: Square Every Digit
        public static int SquareDigits(int n)
        {
            string nStr = n.ToString();
            string resultStr = "";
            for (int i = 0; i < n.ToString().Length; i++)
            {
                int num = (int)Char.GetNumericValue(nStr[i]);
                int calc = num * num;
                resultStr += calc.ToString();
            }
            return Int32.Parse(resultStr);
        }
        // Console.WriteLine(CWars.kyu7.SquareDigits(9119));

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

        // CODEWARS: Get the Middle Character
        public static string GetMiddle(string s)
        {
            return s.Length % 2 == 0 ? s.Substring((s.Length / 2) - 1, 2) : s.Substring(Convert.ToInt32(Math.Floor((double)s.Length / 2)), 1);
        }
        // Console.WriteLine($"Answer: {CWars.kyu7.GetMiddle("test")} Expected: es");
        // Console.WriteLine($"Answer: {CWars.kyu7.GetMiddle("testing")} Expected: t");
        // Console.WriteLine($"Answer: {CWars.kyu7.GetMiddle("middle")} Expected: dd");
        // Console.WriteLine($"Answer: {CWars.kyu7.GetMiddle("A")} Expected: A");

    }
}
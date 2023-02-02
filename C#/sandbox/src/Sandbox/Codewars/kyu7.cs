using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace CWars
{
    public class kyu7
    {
        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
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

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        // CODEWARS - Find the divisors!
        public static int[]? Divisors(int n)
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

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
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

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        // CODEWARS: Square Every Digit / Digit*Digit
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

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
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

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        // CODEWARS: Get the Middle Character
        public static string GetMiddle(string s)
        {
            return s.Length % 2 == 0 ? s.Substring((s.Length / 2) - 1, 2) : s.Substring(Convert.ToInt32(Math.Floor((double)s.Length / 2)), 1);
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        //CODEWARS: Descending Order
        public static int DescendingOrder(int num)
        {
            string nStr = num.ToString();
            int[] nStrArray = new int[nStr.Length];
            for (int i = 0; i < nStr.Length; i++)
            {
                nStrArray[i] = Int32.Parse(nStr.Substring(i,1));                
            }

            nStr = "";
            Array.Sort(nStrArray);
            Array.Reverse(nStrArray);
            foreach (int c in nStrArray)
            {
                nStr += c.ToString();
            }

            int nResult = Int32.Parse(nStr);

            return nResult;
        }
    }
}
using System;
using System.Collections.Generic;

namespace Sandbox.Codewars.kyu4
{
    public class SumStringAsNum
    {
        // CODEWARS: Sum Strings as Numbers - without using BigInteger
        public static string sumStrings(string a, string b)
        {
            List<int> aList = _numList(a);
            List<int> bList = _numList(b);
            string sumString = "";

            if (aList.Count == bList.Count)
            {
                string result = "";
                int carryForward = 0;
                for (int i = aList.Count - 1; i >= 0; i--)
                {
                    int tempResult = aList[i] + bList[i] + (carryForward / 10);
                    result = (tempResult % 10).ToString() + result;
                    carryForward = tempResult - tempResult % 10;
                }
                // return result;
                sumString = (carryForward / 10) == 0 ? result : (carryForward / 10).ToString() + result;
            }
            else if (aList.Count > bList.Count)
            {
                sumString = _addLists(aList, bList);
            }
            else
            {
                sumString = _addLists(bList, aList);
            }

            return sumString.Substring(0, 1) == "0" ? sumString.Substring(1, sumString.Length - 1) : sumString;
        }

        private static List<int> _numList(string str)
        {
            List<int> strList = new List<int>();
            foreach (char s in str)
            {
                strList.Add(Convert.ToInt32(s.ToString()));
            }
            return strList;
        }

        private static string _addLists(List<int> larger, List<int> smaller)
        {
            string result2 = "";
            int carryForward2 = 0;
            int diff = larger.Count - smaller.Count;

            for (int i = larger.Count - 1; i >= 0; i--)
            {
                if (i - diff < smaller.Count && i - diff >= 0)
                {
                    int tempResult2 = larger[i] + smaller[i - diff] + (carryForward2 / 10);
                    result2 = (tempResult2 % 10).ToString() + result2;
                    carryForward2 = tempResult2 - tempResult2 % 10;
                }
                else
                {
                    int tempResult3 = larger[i] + (carryForward2 / 10);
                    result2 = (tempResult3 % 10).ToString() + result2;
                    carryForward2 = tempResult3 - tempResult3 % 10;
                }
            }

            return (carryForward2 / 10) == 0 ? result2 : (carryForward2 / 10).ToString() + result2;
        }
    }
}
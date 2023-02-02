using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CWars
{
    public class kyu4
    {

        // CODEWARS: Adding Big Numbers
        public static string Add(string a, string b)
        {
            // return (UInt64.Parse(a) + UInt64.Parse(b)).ToString();
            return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        // CODEWARS: Human readable duration format
        public static string formatDuration(int seconds)
        {
            List<string> durList = new List<string>();
            int day = 86400;

            //years
            int years = seconds / (day * 365);
            decimal yearsR = (seconds - (years * (day * 365))) % (day * 365); //TODO - check calc

            //days - 86400 seconds
            int days = Convert.ToInt32(Math.Floor(yearsR)) / day;
            // int days = (seconds - (years * (day * 365))) / day;
            decimal daysR = yearsR % day; //TODO - check calc

            //hours - 3600 seconds
            int hours = Convert.ToInt32(Math.Floor(daysR)) / 3600;
            decimal hoursR = daysR % 3600; //TODO - check calc

            //mins - 60 seconds
            int mins = Convert.ToInt32(Math.Floor(hoursR)) / 60;
            decimal minsR = hoursR % 60;

            //secs
            int sec = Convert.ToInt32(minsR % 60);

            if (seconds == 0)
            {
                return "now";
            }
            else
            {
                durList.Add(ConvertTime(years, "year"));
                durList.Add(ConvertTime(days, "day"));
                durList.Add(ConvertTime(hours, "hour"));
                durList.Add(ConvertTime(mins, "minute"));
                durList.Add(ConvertTime(sec, "second"));
                durList.RemoveAll(x => x.Contains("remove"));
            }

            string result = "";
            for (int i = 0; i < durList.Count; i++)
            {
                if (i <= durList.Count - 3)
                {
                    result += $"{durList[i]}, ";
                }
                else if (i == durList.Count - 1 && durList.Count != 1)
                {
                    result += $" and {durList[i]}";
                }
                else
                {
                    result += $"{durList[i]}";
                }
            }

            // return $"Year:{years} Days:{days} Hour:{hours} Minutes:{mins} Seconds:{sec}";
            return result;
        }

        private static string ConvertTime(int time, string type)
        {
            if (time > 0 && time <= 1)
            {
                return $"{time} {type}";
            }
            else if (time > 1)
            {
                return $"{time} {type}s";
            }
            else
            {
                return "remove";
            }
        }
        
        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        // CODEWARS: Sum Strings as Numbers - without using BigInteger
        public static string sumStrings(string a, string b)
        {
            List<int> aList = numList(a);
            List<int> bList = numList(b);
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
                sumString = addLists(aList, bList);
            }
            else
            {
                sumString = addLists(bList, aList);
            }

            return sumString.Substring(0, 1) == "0" ? sumString.Substring(1, sumString.Length - 1) : sumString;
        }

        private static List<int> numList(string str)
        {
            List<int> strList = new List<int>();
            foreach (char s in str)
            {
                strList.Add(Convert.ToInt32(s.ToString()));
            }
            return strList;
        }

        private static string addLists(List<int> larger, List<int> smaller)
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
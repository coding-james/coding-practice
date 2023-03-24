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

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        // CODEWARS: Next bigger number with the same digits
        public static long NextBiggerNumber(long n)
        {
            // Create a List and subList for digits
            List<int> nList = new List<int>();
            List<int> subList = new List<int>();
            string result = "";

            // Add digits to list
            foreach (char digit in n.ToString())
            {
                nList.Add((digit - '0'));
            }

            // from right to left, check for a lower digit, add to subList until a lower digit found then replace
            for (int i = nList.Count - 1; i >= 1; i--)
            {
                if (nList[i] > nList[i - 1])
                {
                    subList.Add(nList[i]);
                    subList.Add(nList[i - 1]);
                    subList.Sort();
                    // if nList[i] is smaller than subList num, then replace and remove from list.
                    // then for remaining replace remaining nList nums with subList nums
                    for (int s = 0; s < subList.Count; s++)
                    {
                        if (nList[i - 1] < subList[s])
                        {
                            nList[i - 1] = subList[s];
                            subList.RemoveAt(s);

                            foreach (int num in subList)
                            {
                                nList[i] = num;
                                i++;
                            }

                            foreach (int digit in nList)
                            {
                                result += digit.ToString();
                            }
                            return long.Parse(result);
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else
                {
                    subList.Add(nList[i]);
                }
            }
            return -1;
        }

        // CODEWARS: Range Extraction
        public static string Extract(int[] args)
        {
            string result = "";
            for (int index = 0; index < args.Length; index++)
            {
                // FOR each number in args, check if next two are in sequence, if so keep working through sequence, recording start and end numbers in sequence
                if (args.Length > index + 2 && args[index + 1] == args[index] + 1 && args[index + 2] == args[index] + 2)
                {
                    int start = args[index];
                    int end = args[index + 2];
                    int endIndex = index + 2;
                    for (int x = endIndex; x < args.Length; x++)
                    {
                        if (args.Length > x + 1 && args[x] + 1 == args[x + 1])
                        {
                            end = args[x + 1];
                            endIndex = x + 1;
                        }
                        else
                        {
                            break;
                        }
                    }
                    result += endIndex + 1 < args.Length ? $"{start}-{end}," : $"{start}-{end}";
                    index = endIndex; // when sequence ends, start at index after sequence
                }
                else
                {
                    // otherwise just add number to string
                    result += index + 1 < args.Length ? $"{args[index]}," : args[index].ToString();
                }
            }
            return result;
        }

        // CODEWARS: Sum of Intervals
        // working with (int,int)[] https://stackoverflow.com/questions/59907372/how-to-use-this-combined-data-type-int-int
        public static int SumIntervals((int, int)[] intervals)
        {
            int result = 0;
            List<int> ranges = new List<int>();

            if (intervals != null && intervals.Length != 0)
            {
                for (int i = 0; i < intervals.Length; i++)
                {
                    ranges = collapseRange(intervals[i].Item1, intervals[i].Item2, ranges);
                }
            }

            // Cycle through again until ranges no longer reduces in size
            int currentRangeCount = 0;
            int newRangeCount = 0;
            do
            {
                currentRangeCount = ranges.Count;
                List<int> rangesNew = new List<int>();
                for (int i = 0; i < ranges.Count; i += 2)
                {
                    rangesNew = collapseRange(ranges[i], ranges[i + 1], rangesNew);
                }
                ranges = rangesNew;
                newRangeCount = ranges.Count;
            }
            while (currentRangeCount != newRangeCount);

            if (ranges.Count > 0)
            {
                for (int i = 0; i < ranges.Count; i += 2)
                {
                    result += ranges[i + 1] - ranges[i];
                }
            }
            return result;
        }

        private static List<int> collapseRange(int start, int end, List<int> inputRange)
        {
            List<int> rangesTmp = inputRange;
            if (rangesTmp.Count == 0)
            {
                rangesTmp.Add(start);
                rangesTmp.Add(end);
            }
            else // check if it overlaps with an existing one
            {
                for (int j = 0; j < rangesTmp.Count; j += 2)
                {
                    if (start >= rangesTmp[j] && end <= rangesTmp[j + 1]) // if interval sits within an existing range
                    {
                        break;
                    }
                    else if (start < rangesTmp[j] && end > rangesTmp[j + 1]) // extend top and bottom if larger range
                    {
                        rangesTmp[j] = start;
                        rangesTmp[j + 1] = end;
                        break;
                    }
                    else if (start >= rangesTmp[j] && start <= rangesTmp[j + 1]) // extend top of range
                    {
                        rangesTmp[j + 1] = end;
                        break;
                    }
                    else if (end <= rangesTmp[j + 1] && end >= rangesTmp[j]) // lower end of range
                    {
                        rangesTmp[j] = start;
                        break;
                    }
                    else if (j == rangesTmp.Count - 2) // on last loop add to ranges
                    {
                        rangesTmp.Add(start);
                        rangesTmp.Add(end);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return rangesTmp;
        }
    }
}
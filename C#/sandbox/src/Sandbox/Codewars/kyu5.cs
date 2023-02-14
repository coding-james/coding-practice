using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml;

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

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        // CODEWARS - Let's Play Darts
        public static string GetScore(double x, double y)
        {
            string result;

            if (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) < 12.70 / 2) // Bull's eye (diameter): `12.70 mm` = DB
            {
                result = "DB";
            }
            else if (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) < 31.8 / 2) // Bull: `31.8 mm` = SB
            {
                result = "SB";
            }
            else if (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) >= 340 / 2) // Outside of the board: `"X"` - 340 mm
            {
                result = "X";
            }
            else if (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) > 198 / 2 && Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) < 214 / 2) // Triple ring inner circle: `198 mm`, Outer:`214 mm`
            {
                result = "T";
            }
            else if (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) > 324 / 2) // Double ring inner circle: `324 mm`, Outer: `340 mm`
            {
                result = "D";
            }
            else
            {
                result = "";
            }

            // Calculate the angle
            if (result == "T" || result == "D" || result == "")
            {
                double radian = MathF.Atan2((float)x, (float)y);
                double angle = (radian * (180 / Math.PI) + 360) % 360;

                switch (angle)
                {
                    case > 351:
                    case <= 9:
                        result += 20;
                        break;
                    case <= 27:
                        result += 1;
                        break;
                    case <= 45:
                        result += 18;
                        break;
                    case <= 63:
                        result += 4;
                        break;
                    case <= 81:
                        result += 13;
                        break;
                    case <= 99:
                        result += 6;
                        break;
                    case <= 117:
                        result += 10;
                        break;
                    case <= 135:
                        result += 15;
                        break;
                    case <= 153:
                        result += 2;
                        break;
                    case <= 171:
                        result += 17;
                        break;
                    case <= 189:
                        result += 3;
                        break;
                    case <= 207:
                        result += 19;
                        break;
                    case <= 225:
                        result += 7;
                        break;
                    case <= 243:
                        result += 16;
                        break;
                    case <= 261:
                        result += 8;
                        break;
                    case <= 279:
                        result += 11;
                        break;
                    case <= 297:
                        result += 14;
                        break;
                    case <= 315:
                        result += 9;
                        break;
                    case <= 333:
                        result += 12;
                        break;
                    case <= 351:
                        result += 5;
                        break;
                    default:
                        result = "not a valide angle";
                        break;
                }
            }
            return result;
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        // CODEWARS - Not very secure
        public static bool Alphanumeric(string str)
        {
            return (Regex.IsMatch(str, "^[a-zA-Z0-9]*$") && str != "");
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        // CODEWARS - First non-repeating character
        public static string FirstNonRepeatingLetter(string s)
        {
            var countLetter = s.ToLower().GroupBy(ch => ch).ToDictionary(group => group.Key, group => group.Count());
            string first = "";
            int found = 0;
            foreach (var letter in countLetter)
            {
                if (letter.Value == 1 && found < 1)
                {
                    first = s.Substring(s.ToLower().IndexOf(letter.Key), 1);
                    found += 1;
                }
            }
            return first;
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        // CODEWARS - Directions Reduction
        public static string[] dirReduc(String[] arr)
        {
            List<string> tempDir = new List<string>(arr);
            int startLen = 0;
            int endLen = 0;

            do
            {
                startLen = tempDir.Count;
                for (int i = 0; i < tempDir.Count - 1; i++)
                {
                    string opposite = "";

                    switch (tempDir[i])
                    {
                        case "NORTH":
                            opposite = "SOUTH";
                            break;
                        case "SOUTH":
                            opposite = "NORTH";
                            break;
                        case "WEST":
                            opposite = "EAST";
                            break;
                        case "EAST":
                            opposite = "WEST";
                            break;
                        default:
                            break;
                    }

                    if (tempDir[i + 1] == opposite)
                    {
                        tempDir.RemoveAt(i);
                        tempDir.RemoveAt(i);
                    }
                }
                endLen = tempDir.Count;
            }
            while (startLen != endLen);
            return tempDir.ToArray();
        }
    }
}
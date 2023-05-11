using System;
using System.Collections.Generic;

namespace Sandbox.Codewars.kyu4
{
    public class HumanReadableFormat
    {
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
                durList.Add(_convertTime(years, "year"));
                durList.Add(_convertTime(days, "day"));
                durList.Add(_convertTime(hours, "hour"));
                durList.Add(_convertTime(mins, "minute"));
                durList.Add(_convertTime(sec, "second"));
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

        private static string _convertTime(int time, string type)
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
    }
}
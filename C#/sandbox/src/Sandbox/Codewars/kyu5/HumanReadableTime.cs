using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Codewars.kyu5
{
    public class HumanReadableTime
    {
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
    }
}

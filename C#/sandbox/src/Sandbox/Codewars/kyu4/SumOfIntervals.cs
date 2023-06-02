using System;
using System.Collections.Generic;

namespace Sandbox.Codewars.kyu4 
{
  public class SunOfIntervals
  {
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
                    ranges = _collapseRange(intervals[i].Item1, intervals[i].Item2, ranges);
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
                    rangesNew = _collapseRange(ranges[i], ranges[i + 1], rangesNew);
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

        private static List<int> _collapseRange(int start, int end, List<int> inputRange)
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
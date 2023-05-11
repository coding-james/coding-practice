using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Codewars.kyu6
{
    public class CountingDuplicates
    {
        // CODEWARS - Counting Duplicates
        public static int DuplicateCount(string str)
        {
            // System.Console.WriteLine($"\n{str}");
            int count = 0;
            var countLetterStr = str.ToLower().GroupBy(ch => ch).ToDictionary(group => group.Key, group => group.Count());
            foreach (var letter in countLetterStr)
            {
                // System.Console.WriteLine($" - {letter.Key} = {letter.Value}");
                if (letter.Value > 1)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

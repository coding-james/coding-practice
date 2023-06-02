using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Codewars.kyu5
{
    public class FirstNonRepeatChar
    {
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
    }
}

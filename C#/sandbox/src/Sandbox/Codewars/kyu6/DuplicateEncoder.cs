using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Codewars.kyu6
{
    public class DuplicateEncoder
    {
        // CODEWARS: Duplicate Encoder
        public static string DuplicateEncode(string word)
        {
            string wordLower = word.ToLower();
            var countLetterStr = wordLower.GroupBy(ch => ch).ToDictionary(group => group.Key, group => group.Count());
            string wordReplace = "";
            foreach (char letter in wordLower)
            {
                if (countLetterStr[letter] > 1)
                {
                    wordReplace += ")";
                }
                else
                {
                    wordReplace += "(";
                }
            }
            return wordReplace;
        }
    }
}

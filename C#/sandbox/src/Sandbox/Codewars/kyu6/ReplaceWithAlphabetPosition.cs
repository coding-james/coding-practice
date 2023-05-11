using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sandbox.Codewars.kyu6
{
    public class ReplaceWithAlphabetPosition
    {
        // CODEWARS: Replace With Alphabet Position
        public static string AlphabetPosition(string text)
        {
            Regex reg = new Regex("[^A-Za-z]");
            string[] letters = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string textPos = "";
            string replaced = reg.Replace(text, "").ToLower();

            for (int item = 0; item < replaced.Length; item++)
            {
                string search = replaced[item].ToString();
                int pos = Array.IndexOf(letters, search);
                textPos = textPos + (pos + 1).ToString();

                if (item < (replaced.Length - 1))
                {
                    textPos = textPos + " ";
                }
            }
            // Console.WriteLine(textPos);
            return textPos;
        }
    }
}

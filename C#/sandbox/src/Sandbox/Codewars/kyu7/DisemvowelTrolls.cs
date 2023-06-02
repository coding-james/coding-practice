using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Codewars.kyu7
{
    public class DisemvowelTrolls
    {
        // CODEWARS: Disemvowel Trolls
        public static string Disemvowel(string str)
        {
            if (str.Length > 0)
            {
                return str = str.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "").Replace("A", "").Replace("E", "").Replace("I", "").Replace("O", "").Replace("U", "");
            }
            else
            {
                return str;
            }
        }
    }
}

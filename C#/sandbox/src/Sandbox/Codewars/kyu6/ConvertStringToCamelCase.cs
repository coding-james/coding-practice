using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Codewars.kyu6
{
    public class ConvertStringToCamelCase
    {
        // CODEWARS: Convert string to camel case
        public static string ToCamelCase(string str)
        {
            string StrNew = str;
            string StrFinal = "";
            for (int i = 0; i < StrNew.Length; i++)
            {
                char letter = char.Parse(StrNew.Substring(i, 1));
                if (!char.IsLetter(letter))
                {
                    StrFinal += (StrNew.Substring(i + 1, 1)).ToUpper();
                    i++;
                }
                else
                {
                    StrFinal += StrNew.Substring(i, 1);
                }
            }
            return StrFinal;
        }
    }
}

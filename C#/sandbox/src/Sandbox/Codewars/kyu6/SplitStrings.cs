using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Codewars.kyu6
{
    public class SplitStrings
    {
        // CODEWARS: Split Strings
        public static string[] SplitString(string str)
        {
            int loops = Convert.ToInt32(Math.Ceiling((double)str.Length / 2));
            // System.Console.WriteLine(loops);
            string[] result = new string[loops];
            int pair = 0;
            for (int i = 0; i < (double)str.Length / 2; i++)
            {
                if ((str.Length % 2 == 0) || (i < (loops - 1) && str.Length % 2 != 0))
                {
                    result[i] = str.Substring(pair, 2);
                    pair += 2;
                }
                else
                {
                    result[i] = str.Substring(pair, 1) + "_";
                    pair += 2;
                }
            }

            // foreach (string s in result)
            // {
            //     System.Console.WriteLine(s);
            // }
            return result;
        }
    }
}

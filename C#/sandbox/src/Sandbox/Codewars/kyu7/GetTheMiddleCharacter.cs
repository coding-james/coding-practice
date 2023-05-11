using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Codewars.kyu7
{
    public class GetTheMiddleCharacter
    {
        // CODEWARS: Get the Middle Character
        public static string GetMiddle(string s)
        {
            return s.Length % 2 == 0 ? s.Substring((s.Length / 2) - 1, 2) : s.Substring(Convert.ToInt32(Math.Floor((double)s.Length / 2)), 1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Codewars.kyu7
{
    public class YoureASquare
    {
        // CODEWARS - You're a square!
        public static bool IsSquare(int n)
        {
            if (n >= 0)
            {
                int sr = (int)Math.Sqrt(n);
                return (sr * sr == n);
            }
            return false;
        }
    }
}

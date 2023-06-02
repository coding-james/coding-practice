using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Codewars.kyu5
{
    public class ValidParentheses
    {
        // CODEWARS - Valid Parentheses
        public static bool Solution(string input)
        {
            int countOpen = 0;
            int countClose = 0;
            foreach (char c in input)
            {
                if (c == Char.Parse("(") && countOpen >= countClose)
                {
                    countOpen++;
                }
                else if (c == Char.Parse(")") && countOpen >= countClose)
                {
                    countClose++;
                }
                else if (c == Char.Parse(")"))
                {
                    return false;
                }
                else
                {
                    continue;
                }
            }
            return countOpen == countClose ? true : false;
        }
    }
}

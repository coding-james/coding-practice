using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sandbox.Codewars.kyu5
{
    public class NotVerySecure
    {
        // CODEWARS - Not very secure
        public static bool Alphanumeric(string str)
        {
            return (Regex.IsMatch(str, "^[a-zA-Z0-9]*$") && str != "");
        }
    }
}

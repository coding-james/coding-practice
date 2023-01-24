using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CWars
{
    public class kyu4
    {
        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        // CODEWARS: Adding Big Numbers
        public static string Add(string a, string b)
        {
            // return (UInt64.Parse(a) + UInt64.Parse(b)).ToString();
            return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
        }
    }
    // Console.WriteLine($"Answer: {CWars.kyu4.Add("91","19")} Expected: 110");
    // Console.WriteLine($"Answer: {CWars.kyu4.Add("123456789", "987654322")} Expected: 1111111111");
    // Console.WriteLine($"Answer: {CWars.kyu4.Add("999999999", "1")} Expected: 1000000000");
}

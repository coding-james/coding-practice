using System;
using System.Numerics;

namespace Sandbox.Codewars.kyu4
{
    public class AddingBigNum
    {
        // CODEWARS: Adding Big Numbers
        public static string Add(string a, string b)
        {
            // return (UInt64.Parse(a) + UInt64.Parse(b)).ToString();
            return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
        }
    }
}
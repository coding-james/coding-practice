using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Codewars.kyu7
{
    public class FindTheDivisors
    {
        // CODEWARS - Find the divisors!
        public static int[]? Divisors(int n)
        {
            List<int> result = new List<int>();

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    result.Add(i);
                }
            }

            if (result.Count != 0)
            {
                int[] resultArray = new int[result.Count];

                for (int index = 0; index < result.Count; index++)
                {
                    resultArray[index] = result[index];
                }
                return resultArray;
            }
            else
            {
                return null;
            }
        }
    }
}

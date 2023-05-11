using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Codewars.kyu6
{
    public class TwoSum
    {
        // CODEWARS: Two Sum
        public static int[] TwoSumSolution(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int x = i + 1; x < numbers.Length; x++)
                {
                    if (numbers[i] + numbers[x] == target)
                    {
                        return new int[] { i, x };
                    }
                }
            }
            throw new ArgumentException("Bad numbers");
        }
    }
}

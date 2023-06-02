using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Codewars.kyu5
{
    public class MoveZerosToEnd
    {
        // CODEWARS - Moving Zeros To The End
        public static int[] MoveZeroes(int[] arr)
        {
            int[] result = new int[arr.Length];
            int i = 0;
            int zeroCount = 0;
            foreach (int a in arr)
            {
                if (a != 0)
                {
                    result[i] = a;
                    i++;
                }
                else
                {
                    zeroCount++;
                }
            }

            for (int n = 1; n <= zeroCount; n++)
            {
                result[i] = 0;
                i++;
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Codewars.kyu6
{
    public class ArrayDiff
    {
        // CODEWARS - Array.diff
        public static int[] ArrayCompare(int[] a, int[] b)
        {
            int[] result = new int[a.Length];
            int index = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (!(Array.Exists(b, element => element == a[i])))
                {
                    result[index] = a[i];
                    index++;
                }
            }

            int[] resultArray = new int[index];
            for (int x = 0; x < resultArray.Length; x++)
            {
                resultArray[x] = result[x];
            }

            return resultArray;
        }
    }
}

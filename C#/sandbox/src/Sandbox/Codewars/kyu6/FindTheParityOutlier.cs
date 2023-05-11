using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Codewars.kyu6
{
    public class FindTheParityOutlier
    {
        // CODEWARS: Find the Parity Outlier
        public static int Find(int[] integers)
        {
            int evenCount = 0;
            int oddCount = 0;
            int lastEven = int.MinValue;
            int lastOdd = int.MinValue;

            foreach (int num in integers)
            {
                if (num % 2 == 0)
                {
                    evenCount++;
                    lastEven = num;
                }
                else
                {
                    oddCount++;
                    lastOdd = num;
                }
            }

            if (evenCount == 1)
            {
                return lastEven;
            }
            else
            {
                return lastOdd;
            }
        }
    }
}

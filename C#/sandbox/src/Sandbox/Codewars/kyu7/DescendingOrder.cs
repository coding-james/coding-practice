using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Codewars.kyu7
{
    public class DescendingOrder
    {
        //CODEWARS: Descending Order
        public static int DescOrder(int num)
        {
            string nStr = num.ToString();
            int[] nStrArray = new int[nStr.Length];
            for (int i = 0; i < nStr.Length; i++)
            {
                nStrArray[i] = Int32.Parse(nStr.Substring(i, 1));
            }

            nStr = "";
            Array.Sort(nStrArray);
            Array.Reverse(nStrArray);
            foreach (int c in nStrArray)
            {
                nStr += c.ToString();
            }

            int nResult = Int32.Parse(nStr);

            return nResult;
        }
    }
}

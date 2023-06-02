using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Codewars.kyu6
{
    public class SumOfDigits
    {
        // CODEWARS: Sum of Digits / Digital Root
        public static int DigitalRoot(long n) //static removed from solution on CodeWars
        {
            // System.Console.WriteLine($"\nStart {n}");
            string nStr = n.ToString();
            int result = 0;
            List<int> nList = new List<int>();
            do
            {
                //split digits
                foreach (char nChar in nStr)
                {
                    int num = nChar - '0';
                    nList.Add(num);
                }

                // sum together to get result
                result = 0;
                foreach (int nValue in nList)
                {
                    result += nValue;
                }
                nStr = result.ToString();
                nList.Clear();
                // System.Console.WriteLine(result);
            }
            while (result.ToString().Length > 1);
            return result;
        }
    }
}

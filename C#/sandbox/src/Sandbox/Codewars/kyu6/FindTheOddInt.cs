using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Codewars.kyu6
{
    public class FindTheOddInt
    {
        //CODEWARS: Find the odd int
        public static int find_it(int[] seq)
        {
            int? odd = null;
            while (odd.HasValue == false)
            {
                foreach (int num in seq)
                {
                    int count = 0;
                    for (int i = 0; i < seq.Length; i++)
                    {

                        if (num == seq[i])
                        {
                            count++;
                        }
                    }

                    if (count % 2 != 0)
                    {
                        odd = num;
                    }

                }
            }
            return odd.Value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Codewars.kyu6
{
    public class FindTheUniqueNumber
    {
        // CODEWARS: Find the unique number
        public static int GetUnique(IEnumerable<int> numbers)
        {
            int unique = 0;
            var countN = numbers.GroupBy(i => i).ToDictionary(group => group.Key, group => group.Count());

            foreach (var number in countN)
            {
                if (number.Value == 1)
                {
                    unique += number.Key;
                }
            }
            return unique;
        }

        // Original attempt, works but fails Random Test?
        public static int GetUniqueOLD(IEnumerable<int> numbers)
        {
            int numOne = ((int[])numbers)[0];
            int numTwo = Int32.MinValue;
            int numOneCount = 0;
            int numTwoCount = 0;
            int index = 0;

            for (int i = 0; i < ((int[])numbers).Length; i++)
            {
                if ((numOneCount == 1 && numTwoCount > 2) || (numOneCount > 2 && numTwoCount == 1))
                {
                    return numOneCount < numTwoCount ? numOne : numTwo;
                }
                else if (((int[])numbers)[index] == numOne)
                {
                    numOneCount++;
                    index++;
                }
                else if (((int[])numbers)[index] == numTwo)
                {
                    numTwoCount++;
                    index++;
                }
                else
                {
                    numTwo = ((int[])numbers)[index];
                    numTwoCount++;
                    index++;
                }
            }
            return numOneCount < numTwoCount ? numOne : numTwo;
        }
    }
}

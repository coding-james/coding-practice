using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Codewars.kyu6
{
    public class CreatePhoneNumber
    {
        // CODEWARS - Create Phone Number
        public static string CreatePhoneNum(int[] numbers)
        {
            return $"({string.Join("", numbers[0..3])}) {string.Join("", numbers[3..6])}-{string.Join("", numbers[6..10])}";
        }
    }
}

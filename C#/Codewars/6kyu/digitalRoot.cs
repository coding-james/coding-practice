// CODEWARS: Sum of Digits / Digital Root

using System.Collections.Generic;

public class Number
{
    public static int DigitalRoot(long n) //static removed from solution on CodeWars
        {
            // Your awesome code here!
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

// Console.WriteLine($"{Sandbox.CodeWars.DigitalRoot(16)} = 7");
// Console.WriteLine($"{Sandbox.CodeWars.DigitalRoot(456)} = 6");
// Console.WriteLine($"{Sandbox.CodeWars.DigitalRoot(132189)} = 6");
// Console.WriteLine($"{Sandbox.CodeWars.DigitalRoot(493193)} = 2");
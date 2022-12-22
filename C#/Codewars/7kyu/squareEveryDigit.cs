using System;

public class Kata
{
  public static int SquareDigits(int n)
  {
    string nStr = n.ToString();
            string resultStr = "";
            for (int i = 0; i < n.ToString().Length; i++)
            {
                int num = (int)Char.GetNumericValue(nStr[i]);
                int calc = num * num;
                resultStr += calc.ToString();
            }
            return Int32.Parse(resultStr);
  }
}
// Console.WriteLine(Sandbox.CodeWars.SquareDigits(9119));
// Codewars: Even or Odd

using System;

namespace Solution
{
  public class SolutionClass
  {
    public static string EvenOrOdd(int number)
    {
      if (number % 2 == 0)
      {
        return "Even";
      } else {
        return "Odd";
      }
    }
  }
}
// Console.WriteLine(Sandbox.CodeWars.EvenOrOdd(4));
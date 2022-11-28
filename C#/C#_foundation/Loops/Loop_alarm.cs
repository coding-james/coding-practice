// Do While Loop - will always run once.
using System;

namespace DoWhileLoop
{
  class Program
  {
    static void Main(string[] args)
    {
      bool buttonClick = true;
      
      do
      {
        Console.WriteLine("This is an ALARM!");
      } while (!buttonClick);

      Console.WriteLine("Time for a five minute break");
    }
  }
}
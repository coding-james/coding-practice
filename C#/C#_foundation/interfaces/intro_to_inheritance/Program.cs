using System;

namespace LearnInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      Sedan s = new Sedan(60);
      // Call SpeedUp() here
      Console.WriteLine(s.Describe());
      
      Truck t = new Truck(45, 500);
      // Call SpeedUp() here
      Console.WriteLine(t.Describe());
      
      Bicycle b = new Bicycle(10);
      // Call SpeedUp() here
      Console.WriteLine(b.Describe());
    }
  }
}
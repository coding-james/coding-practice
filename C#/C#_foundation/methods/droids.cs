// method overloading

using System;

namespace MethodOverloading
{
  class Program
  {
    static void NameDroids(string name1, string name2)
    {
      Console.WriteLine($"Your droids {name1} and {name2} will be joining your voyage across space!");
    }

    static void NameDroids(string name1, string name2, string name3)
    {
      Console.WriteLine($"Your droids {name1}, {name2} and {name3} will be joining your voyage across space!");
    }

    static void NameDroids()
    {
      Console.WriteLine("Aw, you have no spacefaring droids :(");
    }


    static void Main(string[] args)
    {
      NameDroids("R2-D2", "C-3PO");
      NameDroids("R2-D2", "C-3PO", "K-2SO");
      NameDroids();
    }
    
  }
}
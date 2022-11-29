using System;

namespace StaticMembers
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest.PrintTreeFacts();

      Console.WriteLine(Forest.ForestsCreated); //Print number of forests created
      Forest a = new Forest("Sherwood", "Temperate"); //Add a new forest object
      Forest b = new Forest("Amazon", "Tropical"); //Add a new forest object
      Console.WriteLine(Forest.ForestsCreated); //Print number of forests created
    }
  }
}
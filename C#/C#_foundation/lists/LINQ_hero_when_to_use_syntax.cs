// Change to add back into main
using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnLinq
{
  class Program
  {
    static void Main()
    {
      string[] heroes = { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };

      // Method syntax
      var result = heroes.Select(h => $"Introducing...{h}!");

      // Query syntax
      var spaceIndex = from h in heroes
        where h.Contains(" ")
        select h.IndexOf(" ");
      
      foreach (string h in result)
      {
        Console.WriteLine(h);
      }

      foreach (int h in spaceIndex)
      {
        Console.WriteLine(h);
      }
    }
  }
}
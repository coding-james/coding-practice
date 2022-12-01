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

      // As separate statements
      var HeroesWithC = heroes.Where(h => h.Contains("c"));
      var lowerHeroesWithC = HeroesWithC.Select(h => h.ToLower());

      // As a chained expression
      var sameResult = heroes
      .Where(h => h.Contains("c"))
      .Select(h => h.ToLower());

      Console.WriteLine("Results of separate statements:");
      foreach (string h in lowerHeroesWithC)
      {
        Console.WriteLine(h);
      }
      
      Console.WriteLine("\nResults of chained expression:");
      foreach (string h in sameResult)
      {
        Console.WriteLine(h);
      }
      
    }
  }
}
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
      List<string> heroesList = new List<string> { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };

      var heroesWithSpecialChars = heroesList.Where(h => h.Contains('.') || h.Contains('7'));

      foreach (var h in heroesWithSpecialChars)
      {
        Console.WriteLine(h);
      }
    }
  }
}
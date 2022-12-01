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

      var heroesWithI = from h in heroes
        where h.Contains("i")
        select h;
      
      var underscored = from h in heroes
        select h.Replace(" ", "_");
    }
  }
}
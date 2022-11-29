using System;

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      // Forest f = new Forest();
      // f.Name = "Amazon";
      // f.Biome = "Tropical";
      // f.Trees = 390;
      // Console.WriteLine(f.Name);

      // Forest f2 = new Forest();
      // f2.Name = "Congo";
      // f2.Trees = 0;
      // f2.Biome = "Tropical";
      // Console.WriteLine(f2.Name);

      Forest f = new Forest("Congo", "Tropical");
      f.Trees = 0;
      
      Console.WriteLine(f.Name);
      Console.WriteLine(f.Biome);
      
      Forest r = new Forest("Rendlesham");
      Console.WriteLine(r.Biome);

      Forest s = new Forest("Sherwood", "Temperate");
      Console.WriteLine(s.Trees);
      s.Grow();
      Console.WriteLine(s.Trees);
    }
  }
}
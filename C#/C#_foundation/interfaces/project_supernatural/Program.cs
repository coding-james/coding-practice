// Change to add back into main
using System;

namespace MagicalInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      Storm[] storms = new Storm[10];
      int stormsIndex = 0;

      // Storm s = new Storm("wind", false, "Zul'rajas");
      // Console.WriteLine(s.Announce());     

      Pupil p = new Pupil("Mezil-kree", "Icecrown");
      storms[stormsIndex] = p.CastWindStorm();
      stormsIndex++;
      // Storm windStorm = p.CastWindStorm();
      // Console.WriteLine(windStorm.Announce());

      Mage m = new Mage("Gul’dan", "Draenor");
      storms[stormsIndex] = m.CastRainStorm();
      stormsIndex++;
      Console.WriteLine($"{m.Title} is {m.Origin}");
      // Storm rainStorm = m.CastRainStorm();
      // Console.WriteLine(rainStorm.Announce());

      Archmage a = new Archmage("Nielas Aran", "Stormwind");
      storms[stormsIndex] = a.CastWindStorm();
      stormsIndex++;
      storms[stormsIndex] = a.CastRainStorm();
      stormsIndex++;
      storms[stormsIndex] = a.CastLightningStorm();
      stormsIndex++;
      // Storm archRainStorm = a.CastRainStorm();
      // Storm archLightStorm = a.CastLightningStorm();
      // Console.WriteLine(archRainStorm.Announce());
      // Console.WriteLine(archLightStorm.Announce());

      for (int i = 0; i < stormsIndex; i++)
      {
        Console.WriteLine(storms[i].Announce());
      }         
    }
  }
}
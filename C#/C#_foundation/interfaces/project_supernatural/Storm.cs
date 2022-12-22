// Change to add back into main
// Storm.cs
using System;

namespace MagicalInheritance
{
  class Storm : Spell
  {
  public Storm(string essence, bool isStrong, string caster)
    {
      Essence = essence;
      IsStrong = isStrong;
      Caster = caster;
    }

    public override string Announce()
    {
      if(IsStrong)
      {
        return $"{Caster} cast a strong {Essence} storm!";
      } else {
        return $"{Caster} cast a weak {Essence} storm!";
      }
    }
  }
}
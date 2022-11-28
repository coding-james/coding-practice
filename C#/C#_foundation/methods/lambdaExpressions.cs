// lambda expressions, are great for situations when you need to pass a method as an argument
using System;

namespace AlternateExpressions
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] spaceRocks = {"meteoroid", "meteor", "meteorite"};
      
      // bool makesContact = Array.Exists(spaceRocks, HitGround);
      // bool makesContact = Array.Exists(spaceRocks, (string s) => s == "meteorite"); //directly include expression
      bool makesContact = Array.Exists(spaceRocks, s => s == "meteorite"); // can shorten down to
      
      if (makesContact)
      {
        Console.WriteLine("At least one space rock has reached the Earth's surface!");
      } 
    } 
    
    static bool HitGround(string s)
    {
      return s == "meteorite";
    }
  }
}
// CODEWARS - Who likes it?

using System;

public static class Kata
{
  public static string Likes(string[] name)
  {
    switch (name.Length)
      {
        case 1:
          return $"{name[0]} likes this";
        case 2:
          return $"{name[0]} and {name[1]} like this";
        case 3:
          return $"{name[0]}, {name[1]} and {name[2]} like this";
        case >= 4:
          int extra = name.Length - 2;
          return $"{name[0]}, {name[1]} and {extra} others like this";
        default:
          return "no one likes this";
      }
  }
}

// Console.WriteLine($"{Sandbox.CodeWars.Likes(new string[0])} = no one likes this");
// Console.WriteLine($"{Sandbox.CodeWars.Likes(new string[] {"Peter"})} = Peter likes this");
// Console.WriteLine($"{Sandbox.CodeWars.Likes(new string[] {"Jacob", "Alex"})} = Jacob and Alex like this");
// Console.WriteLine($"{Sandbox.CodeWars.Likes(new string[] {"Max", "John", "Mark"})} = Max, John and Mark like this");
// Console.WriteLine($"{Sandbox.CodeWars.Likes(new string[] {"Alex", "Jacob", "Mark", "Max"})} = Alex, Jacob and 2 others like this");
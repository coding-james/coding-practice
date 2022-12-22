using System;

public static class Kata
{
    public static string Disemvowel(string str)
    {
        if (str.Length > 0)
        {
            return str = str.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "").Replace("A", "").Replace("E", "").Replace("I", "").Replace("O", "").Replace("U", "");
        }
        else
        {
            return str;
        }
    }
}
// Console.WriteLine(Sandbox.CodeWars.Disemvowel("This website is for losers LOL!"));
// Console.WriteLine(Sandbox.CodeWars.Disemvowel("No offense but,\nYour writing is among the worst I've ever read"));
// Console.WriteLine(Sandbox.CodeWars.Disemvowel("What are you, a communist?"));
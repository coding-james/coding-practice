// CODEWARS - Counting Duplicates
using System;
using System.Linq;

public class Kata
{
    public static int DuplicateCount(string str)
    {
        // System.Console.WriteLine($"\n{str}");
        int count = 0;
        var countLetterStr = str.ToLower().GroupBy(ch => ch).ToDictionary(group => group.Key, group => group.Count());
        foreach (var letter in countLetterStr)
        {
            // System.Console.WriteLine($" - {letter.Key} = {letter.Value}");
            if (letter.Value > 1)
            {
                count++;
            }
        }
        return count;
    }
}

// Console.WriteLine($"{Sandbox.CodeWars.DuplicateCount("")} = 0");
// Console.WriteLine($"{Sandbox.CodeWars.DuplicateCount("abcde")} = 0");
// Console.WriteLine($"{Sandbox.CodeWars.DuplicateCount("aabbcde")} = 2");
// Console.WriteLine($"{Sandbox.CodeWars.DuplicateCount("aabBcde")} = 2");
// Console.WriteLine($"{Sandbox.CodeWars.DuplicateCount("Indivisibility")} = 1");
// Console.WriteLine($"{Sandbox.CodeWars.DuplicateCount("Indivisibilities")} = 2");
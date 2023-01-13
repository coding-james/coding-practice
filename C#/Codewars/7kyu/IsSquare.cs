// CODEWARS - You're a square!

using System;

public class Kata
{
    public static bool IsSquare(int n)
    {
        if (n >= 0)
        {
            int sr = (int)Math.Sqrt(n);
            return (sr * sr == n);
        }
        return false;
    }
}

// Console.WriteLine($"Answer: {Sandbox.CodeWars.IsSquare(-1)} Expected: false");
// Console.WriteLine($"Answer: {Sandbox.CodeWars.IsSquare(0)} Expected: true");
// Console.WriteLine($"Answer: {Sandbox.CodeWars.IsSquare(3)} Expected: false");
// Console.WriteLine($"Answer: {Sandbox.CodeWars.IsSquare(4)} Expected: true");
// Console.WriteLine($"Answer: {Sandbox.CodeWars.IsSquare(25)} Expected: true");
// Console.WriteLine($"Answer: {Sandbox.CodeWars.IsSquare(26)} Expected: false");
// Console.WriteLine($"Answer: {Sandbox.CodeWars.IsSquare(605493)} Expected: false");
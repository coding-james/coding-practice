// CODEWARS: Duplicate Encoder
using System.Linq;

public class Kata
{
  public static string DuplicateEncode(string word)
  {
    string wordLower = word.ToLower();
    var countLetterStr = wordLower.GroupBy(ch => ch).ToDictionary(group => group.Key, group => group.Count());
    string wordReplace = "";
    foreach (char letter in wordLower)
    {
      if (countLetterStr[letter] > 1)
      {
        wordReplace += ")";
      }
      else
      {
        wordReplace += "(";
      }
    }
    return wordReplace;
  }
}

// Console.WriteLine($"Answer: {Sandbox.CodeWars.DuplicateEncode("din")} Expected: (((");
// Console.WriteLine($"Answer: {Sandbox.CodeWars.DuplicateEncode("recede")} Expected: ()()()");
// Console.WriteLine($"Answer: {Sandbox.CodeWars.DuplicateEncode("Success")} Expected: )())())");
// Console.WriteLine($"Answer: {Sandbox.CodeWars.DuplicateEncode("(( @")} Expected: ))((");
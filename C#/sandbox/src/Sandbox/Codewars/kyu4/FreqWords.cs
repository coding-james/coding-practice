using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Sandbox.Codewars.kyu4
{
    public class FreqWords
    {
        // CODEWARS: Most frequently used words in a text
        // https://stackoverflow.com/questions/7265315/replace-multiple-characters-in-a-c-sharp-string - removing sequential characters
        public static List<string> Top3(string s)
        {

            string cleanText01 = Regex.Replace(s, "[^a-zA-Z0-9 ']|[']{2}", " ").ToLower(); //Replace Non-Alphanumeric Characters Excluding Space and Apostrophes. Also remove sequential apostrophes 
            string cleanText02 = Regex.Replace(cleanText01, @"\s+", " "); //Replace New Line, Replace Double Spaces
            List<string> words = cleanText02.Trim().Split(" ").ToList();
            var uniqueWords = words.GroupBy(x => x).Select(y => new { item = y.Key, count = y.Count() }).OrderByDescending(x => x.count).ToList();

            List<string> top3Words = new List<string>();

            for (int i = 0; i < Math.Min(3, uniqueWords.Count()); i++)
            {
                if (uniqueWords[i].item != "" && uniqueWords[i].item != "'")
                {
                    top3Words.Add(uniqueWords[i].item);
                }
            }

            return top3Words;
        }
    }
}

// Codewars: Replace With Alphabet Position

using System.Text.RegularExpressions;

public static class Kata
{
    public static string AlphabetPosition(string text)
    {
        Regex reg = new Regex("[^A-Za-z]");
        string[] letters = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        string textPos = "";
        string replaced = reg.Replace(text, "").ToLower();

        for (int item = 0; item < replaced.Length; item++)
        {
            string search = replaced[item].ToString();
            int pos = Array.IndexOf(letters, search); //TODO - why does this line not work? works in other instance?
            textPos = textPos + (pos + 1).ToString();

            if (item < (replaced.Length - 1))
            {
                textPos = textPos + " ";
            }
        }
        Console.WriteLine(textPos);
        // return textPos;
    }
}
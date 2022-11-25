using System;

namespace ArrayLength
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] summerStrut;

      summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito" };

      if(summerStrut.Length == 8) {
        Console.WriteLine("summerStrut Playlist is ready to go!");
      } else if (summerStrut.Length > 8) {
        Console.WriteLine("Too many songs!");
      } else if (summerStrut.Length < 8) {
        Console.WriteLine("Add some songs!");
      }

      int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
      
      Console.WriteLine($"You rated the song {summerStrut[1]} {ratings[1]} stars");

      // Replace items in an Array. Array index begins 0
      summerStrut[7] = "I Like It"; //replace last song with this one
      ratings[7] = 1; //replace song rating

      // Find first song with a 3 star rating
      int ratingPosition = Array.IndexOf(ratings, 3);
      Console.WriteLine($"Song number {ratingPosition + 1} is rated three stars");

      // Find first song with over 10 characters in title
      string longName = Array.Find(summerStrut, title => title.Length > 10);
      Console.WriteLine($"The first song that has more than 10 characters in the title is {longName}.");

      // Sort the playlist alphabetically
      Array.Sort(summerStrut);
      Console.WriteLine(summerStrut[0]); //Print first song
      Console.WriteLine(summerStrut[7]); //Print last song

      // Copy playlist
      string[] SummerStrutCopy = new string [8];
      Array.Copy(summerStrut, SummerStrutCopy, 8);
      Console.WriteLine(SummerStrutCopy[0]);

      // Reverses order of playlist
      Array.Reverse(summerStrut);
      Console.WriteLine(SummerStrutCopy[0]);
      Console.WriteLine(SummerStrutCopy[7]);

      // Turn ratings to zero
      Array.Clear(ratings, 0, ratings.Length);
      Console.WriteLine(ratings[0]);
    }
  }
}
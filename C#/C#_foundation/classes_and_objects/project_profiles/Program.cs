using System;

namespace DatingProfile
{
  class Program
  {
    static void Main(string[] args)
    {
      // Add Profile
      Profile sam = new Profile("Sam Drakkila", 30, "New York", "USA", "he/him");

      Profile holly = new Profile("Holly LastName", 29, pronouns: "she/her");

      // Add Hobbies
      sam.SetHobbies(new string[]{
        "listening to audiobooks and podcasts",
        "playing rec sports like bowling and kickball",
        "writing a speculative fiction novel",
        "reading advice columns"
      });

      // View Profile
     Console.WriteLine(sam.ViewProfile());
     Console.WriteLine(holly.ViewProfile());

    }
  }
}
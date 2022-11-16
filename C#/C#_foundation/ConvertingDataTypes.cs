using System;

namespace FavoriteNumber
{
  class Program
  {
    static void Main(string[] args)
    {
      // Ask user for fave number
      Console.Write("Enter your favorite number!: ");
      
      // Turn that answer into an int
      //   int faveNumber = Console.ReadLine(); // will cause error
    //   int faveNumber = (int)Console.ReadLine(); //trying explicitly will also error
      int faveNumber = Convert.ToInt32(Console.ReadLine()); //using convert class will work

    }
  }
}
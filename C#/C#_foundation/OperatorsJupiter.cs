using System;

namespace PlanetCalculations
{
  class Program
  {
    static void Main(string[] args)
    {  
      // Your Age
      int userAge = 25;

      // Length of years on Jupiter (in Earth years)
      double jupiterYears = 11.86;

      // Age on Jupiter
      double jupiterAge = userAge/jupiterYears;

      // Time to Jupiter
      double journeyToJupiter = 6.142466;

      // New Age on Earth
      double newEarthAge = userAge + journeyToJupiter;

      // New Age on Jupiter
      double newJupiterAge = newEarthAge/jupiterYears;

      // Log calculations to console
      Console.WriteLine("User age: " + userAge);
      Console.WriteLine("User Jupiter age: " + jupiterAge);
      Console.WriteLine("User age after travelling to Jupiter: " + newEarthAge);
      Console.WriteLine("User Jupiter age after travelling to Jupiter: " + newJupiterAge);
    }
  }
}
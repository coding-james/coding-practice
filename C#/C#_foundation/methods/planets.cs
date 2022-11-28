using System;

namespace NamedArguments
{
  class Program
  {
    static void Main(string[] args)
    {
      VisitPlanets(); //call with defaults
      VisitPlanets(numberOfPlanets: 2); //call with change to specified parameter
      VisitPlanets(numberOfPlanets: 2, name: "Buzz Lightyear"); //call with change to specified parameters
    }
    
    static void VisitPlanets(
      string adjective = "brave", // = sets default
      string name = "Cosmonaut", 
      int numberOfPlanets = 0,
      double gForce = 4.2)
    {
      Console.WriteLine($"Welcome back, {adjective} {name}.");
      Console.WriteLine($"You visited {numberOfPlanets} new planets...");
      Console.WriteLine($"...while experiencing a g-force of {gForce} g!");
    }
  }
}
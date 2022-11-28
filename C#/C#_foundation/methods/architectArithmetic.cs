using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Teotihuacan, Mexico
      double totalArea = Rectangle(2500, 1500) + (Circle(375) / 2) + Triangle(500, 750);

      double totalCost = totalArea * 180;
      Console.WriteLine($"Flooring Quote: The cost for flooring material to cover {Math.Round(totalArea, 2)}m2 is {Math.Round(totalCost, 2)} Pesos");
    }

    static double Rectangle(double length, double width)
    {
      return length * width;
    }

    static double Circle(double radius)
    {
      return Math.PI * Math.Pow(radius, 2);
    }
    
    static double Triangle(double bottom, double height)
    {
      return 0.5 * bottom * height;
    }  
  }
}
// For Loop
using System;

namespace ForLoop
{
  class Program
  {
    static void Main(string[] args)
    { 
      for (int week = 1; week < 17; week++)
      {
        CreateTemplate(week);
      }

    }
    
    static void CreateTemplate(int week)
    {
      Console.WriteLine($"Week {week}");
      Console.WriteLine("Announcements: \n \n \n ");
      Console.WriteLine("Report Backs: \n \n \n");
      Console.WriteLine("Discussion Items: \n \n \n");
    }
        
  }
}
using System;
using System.Collections.Generic;

namespace LearnLists
{
  class Program
  {
    static void Main()
    {
      // List<double> marathons = new List<double>();
      // marathons.Add(144.07);
      // marathons.Add(143.12);
      // marathons.Add(146.73);
      // marathons.Add(146.33);

    // Single line to create a list - uses {} instead of ()
      List<double> marathons = new List<double> {144.07, 143.12, 146.73, 146.33};
      
      // Do not delete the code below
      double time = marathons[1];
      
      Console.WriteLine($"The 2012 marathon was ran in {time} minutes!");

      Console.WriteLine(marathons.Count); //Counts number of items in list (4)
      marathons.Add(143.23); //add additional marathon time
      Console.WriteLine(marathons.Contains(143.23)); //checks item appears in list (True)
      Console.WriteLine(marathons.Count); //Counts number of items in list (5)

      Console.WriteLine($"Item 2 is: {marathons[1]}"); //print 2nd item in list
      bool removed = marathons.Remove(143.12); //removes specified item from list
      Console.WriteLine($"Item 2 is now: {marathons[1]}"); //print 2nd item in list
      Console.WriteLine(removed); //contfirms item removed (True)

      // marathons.Clear(); //clear the entire list

      List<double> topMarathons = marathons.GetRange(0,3); //return first three items in list in a new list

      foreach (double time in topMarathons)
      {
        Console.WriteLine(time);
      }
    }
  }
}
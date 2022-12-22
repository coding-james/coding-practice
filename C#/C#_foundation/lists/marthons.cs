// Change to add back into main
using System;
using System.Collections.Generic;

namespace LearnLists
{
  class Program
  {
    static void Main()
    {
      List<double> marathons = new List<double>(); //create list
      marathons.Add(144.07); //add list item
      marathons.Add(143.12);
      Console.WriteLine(marathons[1]); //print 2nd item  
    }
  }
}
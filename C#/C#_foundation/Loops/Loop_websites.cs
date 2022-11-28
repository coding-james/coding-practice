// Re-write while into a foreach

using System;

namespace ComparingLoops
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] websites = { "twitter", "facebook", "gmail" };
    //   int counter = 0;
      
      // while (counter < websites.Length)
      // { 
      //   Console.WriteLine(websites[counter]); 
      //   counter++; 
      // }

      foreach (string website in websites)
      {
        Console.WriteLine(website);
      }
    }
  }
}
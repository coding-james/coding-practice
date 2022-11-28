using System;

namespace JumpStatements
{
  class Program
  {
    static void Main(string[] args)
    {
      bool buttonClick = false;
      int alarmRung = 0;

      do
      {
        Console.WriteLine("BLARRRRR");
        alarmRung++;
        if (alarmRung == 3)
        {
          break;
        }
        
      } while(!buttonClick);
    }
  }
}
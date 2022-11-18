using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");

      // Ask user for target and convert to a double
      Console.WriteLine("What value would you like to make? ");
      string targetString = Console.ReadLine();
      double targetNum = Convert.ToDouble(targetString);

      // 
      Console.WriteLine($"{targetNum} is equal to...");
    
    // Coin Values
      int goldValue = 10;
      int silverValue = 5;

    // Calc number of coins
      double goldCoins = Math.Floor(targetNum / goldValue);
      double remainder = targetNum % goldValue;

      double silverCoins = Math.Floor(remainder / silverValue);
      remainder = Math.Floor(remainder % silverValue);

    // Print Results
      Console.WriteLine($"Gold Coins: {goldCoins}");
      Console.WriteLine($"Silver Coins: {silverCoins}");
      Console.WriteLine($"Bronze Coins: {remainder}");
    }
  }
}
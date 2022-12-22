public class Kata
{
  public static int Find(int[] integers)
  {
    int evenCount = 0;
    int oddCount = 0;
    int lastEven = int.MinValue;
    int lastOdd = int.MinValue;
            
    foreach (int num in integers)
    {
      if (num % 2 == 0)
      {
        evenCount++;
        lastEven = num;
      }
      else
      {
        oddCount++;
        lastOdd = num;
      }
    }

    if (evenCount == 1)
    {
      return lastEven;
    }
    else
    {
      return lastOdd;
    }
  }
}
// Console.WriteLine(Sandbox.CodeWars.Find(new int[] {2,6,8,-10,3}));
// Console.WriteLine(Sandbox.CodeWars.Find(new int[] {206847684,1056521,7,17,1901,21104421,7,1,35521,1,7781}));
// Console.WriteLine(Sandbox.CodeWars.Find(new int[] { int.MaxValue, 0, 1 }));
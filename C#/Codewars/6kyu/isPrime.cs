// CODEWARS = Is a number prime?
public static class Kata
{
  public static bool IsPrime(int n)
  {
 
            if (n == 2 || n == 3)
                return true;

            if (n <= 1 || n % 2 == 0 || n % 3 == 0)
                return false;

            for (int i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0) return false;
            }


            return true;
        }
  
}
// Console.WriteLine(Sandbox.CodeWars.IsPrime(0));
// Console.WriteLine(Sandbox.CodeWars.IsPrime(1));
// Console.WriteLine(Sandbox.CodeWars.IsPrime(2));
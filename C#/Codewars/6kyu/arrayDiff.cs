// CODEWARS - Array.diff
public class Kata
{
  public static int[] ArrayDiff(int[] a, int[] b)
        {
            int[] result = new int[a.Length];
            int index = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (!(Array.Exists(b, element => element == a[i])))
                {
                    result[index] = a[i];
                    index++;
                }
            }
            
            int[] resultArray = new int[index];
            for (int x = 0; x < resultArray.Length; x++)
            {
                resultArray[x] = result[x];
            }

            return resultArray;

        }
}

// System.Console.WriteLine(Sandbox.CodeWars.ArrayDiff(new int[] {1, 2}, new int[] {1}));
// System.Console.WriteLine(Sandbox.CodeWars.ArrayDiff(new int[] {1, 2, 2}, new int[] {1}));
// System.Console.WriteLine(Sandbox.CodeWars.ArrayDiff(new int[] {1, 2, 2}, new int[] {2}));
// System.Console.WriteLine(Sandbox.CodeWars.ArrayDiff(new int[] {}, new int[] {1, 2}));
// System.Console.WriteLine(Sandbox.CodeWars.ArrayDiff(new int[] {1, 2, 3}, new int[] {1, 2}));
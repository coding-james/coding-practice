//Codewars - Find the odd int

namespace Solution
{
  class Kata
    {
    public static int find_it(int[] seq)
        {
            int? odd = null;
            while (odd.HasValue == false)
            {
                foreach (int num in seq)
                {
                    int count = 0;
                    for (int i = 0; i < seq.Length; i++ )
                    {
                        
                        if (num == seq[i])
                        {
                            count++;
                        }
                    }
                    
                    if (count % 2 != 0)
                    {
                        odd = num;
                    }

                }                
            }
            return odd.Value;
        } 
    }
}
// Console.WriteLine(Sandbox.CodeWars.find_it(new int[] {7})); //7
// Console.WriteLine(Sandbox.CodeWars.find_it(new int[] {0})); //0
// Console.WriteLine(Sandbox.CodeWars.find_it(new int[] {1,1,2})); //2
// Console.WriteLine(Sandbox.CodeWars.find_it(new int[] {0,1,0,1,0})); //0
// Console.WriteLine(Sandbox.CodeWars.find_it(new int[] {1,2,2,3,3,3,4,3,3,3,2,2,1})); //4
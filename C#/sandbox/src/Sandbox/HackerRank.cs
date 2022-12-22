// HackerRank Problem Solving
namespace Sandbox
{
    public class HackerRank
    {
        static int solveMeFirst(int a, int b)
        {
            return a + b;
        }


        public static int simpleArraySum(List<int> ar)
        {
            int sum = 0;
            for (int i = 0; i < ar.Count; i++)
            {
                sum += ar[i];
            }
            return sum;
        }

        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int aScore = 0;
            int bScore = 0;
            List<int> results = new List<int>();
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    aScore++;
                }
                else if (a[i] < b[i])
                {
                    bScore++;
                }

            }
            results.Add(aScore);
            results.Add(bScore);
            return results;
        }
    }
}
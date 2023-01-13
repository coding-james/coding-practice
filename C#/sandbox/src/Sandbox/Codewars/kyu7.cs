namespace CWars
{
    public class kyu7
    {
        // CODEWARS: Take a Ten Minute Walk
        public static bool IsValidWalk(string[] walk)
        {
            int nCount = 0;
            int eCount = 0;
            int sCount = 0;
            int wCount = 0;

            for (int i = 0; i < walk.Length; i++)
            {
                switch (walk[i])
                {
                    case "n":
                        nCount++;
                        break;
                    case "e":
                        eCount++;
                        break;
                    case "s":
                        sCount++;
                        break;
                    case "w":
                        wCount++;
                        break;
                    default:
                        break;
                }
            }

            return walk.Length == 10 && nCount == sCount && eCount == wCount ? true : false;
        }

        // Console.WriteLine($"Answer: {CWars.kyu7.IsValidWalk(new string[] {"n","s","n","s","n","s","n","s","n","s"})} Expected: true");
        // Console.WriteLine($"Answer: {CWars.kyu7.IsValidWalk(new string[] {"w","e","w","e","w","e","w","e","w","e","w","e"})} Expected: false");
        // Console.WriteLine($"Answer: {CWars.kyu7.IsValidWalk(new string[] {"w"})} Expected: false");
        // Console.WriteLine($"Answer: {CWars.kyu7.IsValidWalk(new string[] {"n","n","n","s","n","s","n","s","n","s"})} Expected: false");

    }
}
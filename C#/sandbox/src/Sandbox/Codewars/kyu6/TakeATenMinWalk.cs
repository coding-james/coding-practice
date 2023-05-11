using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Codewars.kyu6
{
    public class TakeATenMinWalk
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
    }
}

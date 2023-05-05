using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Codewars.kyu5
{
    public class DirectionsReduction
    {
        // CODEWARS - Directions Reduction
        public static string[] dirReduc(String[] arr)
        {
            List<string> tempDir = new List<string>(arr);
            int startLen = 0;
            int endLen = 0;

            do
            {
                startLen = tempDir.Count;
                for (int i = 0; i < tempDir.Count - 1; i++)
                {
                    string opposite = "";

                    switch (tempDir[i])
                    {
                        case "NORTH":
                            opposite = "SOUTH";
                            break;
                        case "SOUTH":
                            opposite = "NORTH";
                            break;
                        case "WEST":
                            opposite = "EAST";
                            break;
                        case "EAST":
                            opposite = "WEST";
                            break;
                        default:
                            break;
                    }

                    if (tempDir[i + 1] == opposite)
                    {
                        tempDir.RemoveAt(i);
                        tempDir.RemoveAt(i);
                    }
                }
                endLen = tempDir.Count;
            }
            while (startLen != endLen);
            return tempDir.ToArray();
        }
    }
}

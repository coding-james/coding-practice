using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Codewars.kyu5
{
    public class LetsPlayDarts
    {
        // CODEWARS - Let's Play Darts
        public static string GetScore(double x, double y)
        {
            string result;

            if (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) < 12.70 / 2) // Bull's eye (diameter): `12.70 mm` = DB
            {
                result = "DB";
            }
            else if (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) < 31.8 / 2) // Bull: `31.8 mm` = SB
            {
                result = "SB";
            }
            else if (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) >= 340 / 2) // Outside of the board: `"X"` - 340 mm
            {
                result = "X";
            }
            else if (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) > 198 / 2 && Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) < 214 / 2) // Triple ring inner circle: `198 mm`, Outer:`214 mm`
            {
                result = "T";
            }
            else if (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) > 324 / 2) // Double ring inner circle: `324 mm`, Outer: `340 mm`
            {
                result = "D";
            }
            else
            {
                result = "";
            }

            // Calculate the angle
            if (result == "T" || result == "D" || result == "")
            {
                double radian = MathF.Atan2((float)x, (float)y);
                double angle = (radian * (180 / Math.PI) + 360) % 360;

                switch (angle)
                {
                    case > 351:
                    case <= 9:
                        result += 20;
                        break;
                    case <= 27:
                        result += 1;
                        break;
                    case <= 45:
                        result += 18;
                        break;
                    case <= 63:
                        result += 4;
                        break;
                    case <= 81:
                        result += 13;
                        break;
                    case <= 99:
                        result += 6;
                        break;
                    case <= 117:
                        result += 10;
                        break;
                    case <= 135:
                        result += 15;
                        break;
                    case <= 153:
                        result += 2;
                        break;
                    case <= 171:
                        result += 17;
                        break;
                    case <= 189:
                        result += 3;
                        break;
                    case <= 207:
                        result += 19;
                        break;
                    case <= 225:
                        result += 7;
                        break;
                    case <= 243:
                        result += 16;
                        break;
                    case <= 261:
                        result += 8;
                        break;
                    case <= 279:
                        result += 11;
                        break;
                    case <= 297:
                        result += 14;
                        break;
                    case <= 315:
                        result += 9;
                        break;
                    case <= 333:
                        result += 12;
                        break;
                    case <= 351:
                        result += 5;
                        break;
                    default:
                        result = "not a valide angle";
                        break;
                }
            }
            return result;
        }
    }
}

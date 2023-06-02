using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Codewars.kyu6
{
    public class RomanNumeralsEncoder
    {
        // CODEWARS: Roman Numerals Encoder
        public static string RomanConvert(int n)
        {
            string nStr = n.ToString();
            string result = "";

            for (int i = 0; i < nStr.Length; i++)
            {
                char digit = char.Parse(nStr.Substring(i, 1));

                if (nStr.Length == 4 && i == 0)
                {
                    switch (digit)
                    {
                        case '1':
                            result += "M";
                            break;
                        case '2':
                            result += "MM";
                            break;
                        case '3':
                            result += "MMM";
                            break;
                        default:
                            break;
                    }
                }
                else if (nStr.Length >= 3 && nStr.Length - i == 3)
                {
                    switch (digit)
                    {
                        case '1':
                            result += "C";
                            break;
                        case '2':
                            result += "CC";
                            break;
                        case '3':
                            result += "CCC";
                            break;
                        case '4':
                            result += "CD";
                            break;
                        case '5':
                            result += "D";
                            break;
                        case '6':
                            result += "DC";
                            break;
                        case '7':
                            result += "DCC";
                            break;
                        case '8':
                            result += "DCCC";
                            break;
                        case '9':
                            result += "CM";
                            break;
                        default:
                            break;
                    }
                }
                else if (nStr.Length >= 2 && nStr.Length - i == 2)
                {
                    switch (digit)
                    {
                        case '1':
                            result += "X";
                            break;
                        case '2':
                            result += "XX";
                            break;
                        case '3':
                            result += "XXX";
                            break;
                        case '4':
                            result += "XL";
                            break;
                        case '5':
                            result += "L";
                            break;
                        case '6':
                            result += "LX";
                            break;
                        case '7':
                            result += "LXX";
                            break;
                        case '8':
                            result += "LXXX";
                            break;
                        case '9':
                            result += "XC";
                            break;
                        default:
                            break;
                    }
                }
                else if (nStr.Length >= 1 && nStr.Length - i == 1)
                {
                    switch (digit)
                    {
                        case '1':
                            result += "I";
                            break;
                        case '2':
                            result += "II";
                            break;
                        case '3':
                            result += "III";
                            break;
                        case '4':
                            result += "IV";
                            break;
                        case '5':
                            result += "V";
                            break;
                        case '6':
                            result += "VI";
                            break;
                        case '7':
                            result += "VII";
                            break;
                        case '8':
                            result += "VIII";
                            break;
                        case '9':
                            result += "IX";
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    result += "";
                }
            }
            return result;
        }
    }
}

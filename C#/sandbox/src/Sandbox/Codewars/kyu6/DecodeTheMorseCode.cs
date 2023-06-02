using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Codewars.kyu6
{
    public class DecodeTheMorseCode
    {
        // CODEWARS: Decode the Morse code
        public static string Decode(string morseCode)
        {
            List<string> codeList = new List<string>(morseCode.Trim().Split(" "));
            string message = "";

            foreach (string s in codeList)
            {
                // message = s == ""? message.Trim() + " ": message + MorseCode.Get(s); //CodeWars challenge has MorseCode function
                message = s == "" ? message.Trim() + " " : message + _getMorseCode(s);
            }
            return message;
        }

        private static string _getMorseCode(string snip)
        {
            switch (snip)
            {
                case ".-":
                    return "A";
                case "-...":
                    return "B";
                case "-.-.":
                    return "C";
                case "-..":
                    return "D";
                case ".":
                    return "E";
                case "..-.":
                    return "F";
                case "--.":
                    return "G";
                case "....":
                    return "H";
                case "..":
                    return "I";
                case ".---":
                    return "J";
                case "-.-":
                    return "K";
                case ".-..":
                    return "L";
                case "--":
                    return "M";
                case "-.":
                    return "N";
                case "---":
                    return "O";
                case ".--.":
                    return "P";
                case "--.-":
                    return "Q";
                case ".-.":
                    return "R";
                case "...":
                    return "S";
                case "-":
                    return "T";
                case "..-":
                    return "U";
                case "...-":
                    return "V";
                case ".--":
                    return "W";
                case "-..-":
                    return "X";
                case "-.--":
                    return "Y";
                case "--..":
                    return "Z";
                case "-----":
                    return "0";
                case ".----":
                    return "1";
                case "..---":
                    return "2";
                case "...--":
                    return "3";
                case "....-":
                    return "4";
                case ".....":
                    return "5";
                case "-....":
                    return "6";
                case "--...":
                    return "7";
                case "---..":
                    return "8";
                case "----.":
                    return "9";
                case ".-.-.-":
                    return ".";
                case "--..--":
                    return ",";
                default:
                    return "";
            }
        }
    }
}

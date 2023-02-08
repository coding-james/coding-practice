using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CWars
{
    public class kyu6
    {
        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
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

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        // CODEWARS - Array.diff
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

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        // CODEWARS - Counting Duplicates
        public static int DuplicateCount(string str)
        {
            // System.Console.WriteLine($"\n{str}");
            int count = 0;
            var countLetterStr = str.ToLower().GroupBy(ch => ch).ToDictionary(group => group.Key, group => group.Count());
            foreach (var letter in countLetterStr)
            {
                // System.Console.WriteLine($" - {letter.Key} = {letter.Value}");
                if (letter.Value > 1)
                {
                    count++;
                }
            }
            return count;
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        // CODEWARS - Create Phone Number
        public static string CreatePhoneNumber(int[] numbers)
        {
            return $"({string.Join("", numbers[0..3])}) {string.Join("", numbers[3..6])}-{string.Join("", numbers[6..10])}";
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        // CODEWARS: Sum of Digits / Digital Root
        public static int DigitalRoot(long n) //static removed from solution on CodeWars
        {
            // Your awesome code here!
            // System.Console.WriteLine($"\nStart {n}");
            string nStr = n.ToString();
            int result = 0;
            List<int> nList = new List<int>();
            do
            {

                //split digits
                foreach (char nChar in nStr)
                {
                    int num = nChar - '0';
                    nList.Add(num);
                }

                // sum together to get result
                result = 0;
                foreach (int nValue in nList)
                {
                    result += nValue;
                }
                nStr = result.ToString();
                nList.Clear();
                // System.Console.WriteLine(result);
            }
            while (result.ToString().Length > 1);
            return result;
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        // CODEWARS: Duplicate Encoder
        public static string DuplicateEncode(string word)
        {
            string wordLower = word.ToLower();
            var countLetterStr = wordLower.GroupBy(ch => ch).ToDictionary(group => group.Key, group => group.Count());
            string wordReplace = "";
            foreach (char letter in wordLower)
            {
                if (countLetterStr[letter] > 1)
                {
                    wordReplace += ")";
                }
                else
                {
                    wordReplace += "(";
                }
            }
            return wordReplace;
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        //CODEWARS: Find the odd int
        public static int find_it(int[] seq)
        {
            int? odd = null;
            while (odd.HasValue == false)
            {
                foreach (int num in seq)
                {
                    int count = 0;
                    for (int i = 0; i < seq.Length; i++)
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

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        // CODEWARS: Find the Parity Outlier
        public static int Find(int[] integers)
        {
            int evenCount = 0;
            int oddCount = 0;
            int lastEven = int.MinValue;
            int lastOdd = int.MinValue;

            foreach (int num in integers)
            {
                if (num % 2 == 0)
                {
                    evenCount++;
                    lastEven = num;
                }
                else
                {
                    oddCount++;
                    lastOdd = num;
                }
            }

            if (evenCount == 1)
            {
                return lastEven;
            }
            else
            {
                return lastOdd;
            }
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        // CODEWARS: Is a number prime?
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

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        // CODEWARS: Mutliple of 3 or 5
        public static int MultiOf3or5(int value)
        {
            int result = 0;
            for (int num = (value - 1); num > 0; num--)
            {
                if (num % 3 == 0 || num % 5 == 0)
                {
                    result += num;
                }
            }
            return result;
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        // CODEWARS - Who likes it?
        public static string Likes(string[] name)
        {
            switch (name.Length)
            {
                case 1:
                    return $"{name[0]} likes this";
                case 2:
                    return $"{name[0]} and {name[1]} like this";
                case 3:
                    return $"{name[0]}, {name[1]} and {name[2]} like this";
                case >= 4:
                    int extra = name.Length - 2;
                    return $"{name[0]}, {name[1]} and {extra} others like this";
                default:
                    return "no one likes this";
            }
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        // CODEWARS: Replace With Alphabet Position
        public static string AlphabetPosition(string text)
        {
            Regex reg = new Regex("[^A-Za-z]");
            string[] letters = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string textPos = "";
            string replaced = reg.Replace(text, "").ToLower();

            for (int item = 0; item < replaced.Length; item++)
            {
                string search = replaced[item].ToString();
                int pos = Array.IndexOf(letters, search);
                textPos = textPos + (pos + 1).ToString();

                if (item < (replaced.Length - 1))
                {
                    textPos = textPos + " ";
                }
            }
            // Console.WriteLine(textPos);
            return textPos;
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        // CODEWARS: Find the unique number
        public static int GetUnique(IEnumerable<int> numbers)
        {
            int unique = 0;
            var countN = numbers.GroupBy(i => i).ToDictionary(group => group.Key, group => group.Count());

            foreach (var number in countN)
            {
                if (number.Value == 1)
                {
                    unique += number.Key;
                }
            }
            return unique;
        }

        // Original attempt, works but fails Random Test?
        public static int GetUniqueOLD(IEnumerable<int> numbers)
        {
            int numOne = ((int[])numbers)[0];
            int numTwo = Int32.MinValue;
            int numOneCount = 0;
            int numTwoCount = 0;
            int index = 0;

            for (int i = 0; i < ((int[])numbers).Length; i++)
            {
                if ((numOneCount == 1 && numTwoCount > 2) || (numOneCount > 2 && numTwoCount == 1))
                {
                    return numOneCount < numTwoCount ? numOne : numTwo;
                }
                else if (((int[])numbers)[index] == numOne)
                {
                    numOneCount++;
                    index++;
                }
                else if (((int[])numbers)[index] == numTwo)
                {
                    numTwoCount++;
                    index++;
                }
                else
                {
                    numTwo = ((int[])numbers)[index];
                    numTwoCount++;
                    index++;
                }
            }
            return numOneCount < numTwoCount ? numOne : numTwo;
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        // CODEWARS: Convert string to camel case
        public static string ToCamelCase(string str)
        {
            string StrNew = str;
            string StrFinal = "";
            for (int i = 0; i < StrNew.Length; i++)
            {
                char letter = char.Parse(StrNew.Substring(i, 1));
                if (!char.IsLetter(letter))
                {
                    StrFinal += (StrNew.Substring(i + 1, 1)).ToUpper();
                    i++;
                }
                else
                {
                    StrFinal += StrNew.Substring(i, 1);
                }
            }
            return StrFinal;
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
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

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        // CODEWARS: Two Sum
        public static int[] TwoSum(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int x = i + 1; x < numbers.Length; x++)
                {
                    if (numbers[i] + numbers[x] == target)
                    {
                        return new int[] { i, x };
                    }
                }
            }
            throw new ArgumentException("Bad numbers");
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        // CODEWARS: Split Strings
        public static string[] SplitString(string str)
        {
            int loops = Convert.ToInt32(Math.Ceiling((double)str.Length / 2));
            // System.Console.WriteLine(loops);
            string[] result = new string[loops];
            int pair = 0;
            for (int i = 0; i < (double)str.Length / 2; i++)
            {
                if ((str.Length % 2 == 0) || (i < (loops - 1) && str.Length % 2 != 0))
                {
                    result[i] = str.Substring(pair, 2);
                    pair += 2;
                }
                else
                {
                    result[i] = str.Substring(pair, 1) + "_";
                    pair += 2;
                }
            }

            // foreach (string s in result)
            // {
            //     System.Console.WriteLine(s);
            // }
            return result;
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        // CODEWARS: Decode the Morse code
        public static string Decode(string morseCode)
        {
            List<string> codeList = new List<string>(morseCode.Trim().Split(" "));
            string message = "";

            foreach(string s in codeList)
            {
                // message = s == ""? message.Trim() + " ": message + MorseCode.Get(s); //CodeWars challenge has MorseCode function
                message = s == ""? message.Trim() + " ": message + getMorseCode(s);
            }
            return message;
        }

        private static string getMorseCode(string snip)
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
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CWars
{
    public class kyu6
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
        // Console.WriteLine($"Answer: {CWars.kyu6.IsValidWalk(new string[] {"n","s","n","s","n","s","n","s","n","s"})} Expected: true");
        // Console.WriteLine($"Answer: {CWars.kyu6.IsValidWalk(new string[] {"w","e","w","e","w","e","w","e","w","e","w","e"})} Expected: false");
        // Console.WriteLine($"Answer: {CWars.kyu6.IsValidWalk(new string[] {"w"})} Expected: false");
        // Console.WriteLine($"Answer: {CWars.kyu6.IsValidWalk(new string[] {"n","n","n","s","n","s","n","s","n","s"})} Expected: false");


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
        // System.Console.WriteLine(CWars.kyu6.ArrayDiff(new int[] {1, 2}, new int[] {1}));
        // System.Console.WriteLine(CWars.kyu6.ArrayDiff(new int[] {1, 2, 2}, new int[] {1}));
        // System.Console.WriteLine(CWars.kyu6.ArrayDiff(new int[] {1, 2, 2}, new int[] {2}));
        // System.Console.WriteLine(CWars.kyu6.ArrayDiff(new int[] {}, new int[] {1, 2}));
        // System.Console.WriteLine(CWars.kyu6.ArrayDiff(new int[] {1, 2, 3}, new int[] {1, 2}));


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
        // Console.WriteLine($"{CWars.kyu6.DuplicateCount("")} = 0");
        // Console.WriteLine($"{CWars.kyu6.DuplicateCount("abcde")} = 0");
        // Console.WriteLine($"{CWars.kyu6.DuplicateCount("aabbcde")} = 2");
        // Console.WriteLine($"{CWars.kyu6.DuplicateCount("aabBcde")} = 2");
        // Console.WriteLine($"{CWars.kyu6.DuplicateCount("Indivisibility")} = 1");
        // Console.WriteLine($"{CWars.kyu6.DuplicateCount("Indivisibilities")} = 2");

        // CODEWARS - Create Phone Number
        public static string CreatePhoneNumber(int[] numbers)
        {
            return $"({string.Join("", numbers[0..3])}) {string.Join("", numbers[3..6])}-{string.Join("", numbers[6..10])}";
        }
        // Console.WriteLine($"{CWars.kyu6.CreatePhoneNumber(new int[]{1,2,3,4,5,6,7,8,9,0})} = (123) 456-7890");


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
        // Console.WriteLine($"{CWars.kyu6.DigitalRoot(16)} = 7");
        // Console.WriteLine($"{CWars.kyu6.DigitalRoot(456)} = 6");
        // Console.WriteLine($"{CWars.kyu6.DigitalRoot(132189)} = 6");
        // Console.WriteLine($"{CWars.kyu6.DigitalRoot(493193)} = 2");


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
        // Console.WriteLine($"Answer: {CWars.kyu6.DuplicateEncode("din")} Expected: (((");
        // Console.WriteLine($"Answer: {CWars.kyu6.DuplicateEncode("recede")} Expected: ()()()");
        // Console.WriteLine($"Answer: {CWars.kyu6.DuplicateEncode("Success")} Expected: )())())");
        // Console.WriteLine($"Answer: {CWars.kyu6.DuplicateEncode("(( @")} Expected: ))((");


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
        // Console.WriteLine(CWars.kyu6.find_it(new int[] {7})); //7
        // Console.WriteLine(CWars.kyu6.find_it(new int[] {0})); //0
        // Console.WriteLine(CWars.kyu6.find_it(new int[] {1,1,2})); //2
        // Console.WriteLine(CWars.kyu6.find_it(new int[] {0,1,0,1,0})); //0
        // Console.WriteLine(CWars.kyu6.find_it(new int[] {1,2,2,3,3,3,4,3,3,3,2,2,1})); //4


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
        // Console.WriteLine(CWars.kyu6.Find(new int[] {2,6,8,-10,3}));
        // Console.WriteLine(CWars.kyu6.Find(new int[] {206847684,1056521,7,17,1901,21104421,7,1,35521,1,7781}));
        // Console.WriteLine(CWars.kyu6.Find(new int[] { int.MaxValue, 0, 1 }));


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
        // Console.WriteLine(CWars.kyu6.IsPrime(0));
        // Console.WriteLine(CWars.kyu6.IsPrime(1));
        // Console.WriteLine(CWars.kyu6.IsPrime(2));

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
        // Console.WriteLine(CWars.kyu6.MultiOf3or5(10));     


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
        // Console.WriteLine($"{CWars.kyu6.Likes(new string[0])} = no one likes this");
        // Console.WriteLine($"{CWars.kyu6.Likes(new string[] {"Peter"})} = Peter likes this");
        // Console.WriteLine($"{CWars.kyu6.Likes(new string[] {"Jacob", "Alex"})} = Jacob and Alex like this");
        // Console.WriteLine($"{CWars.kyu6.Likes(new string[] {"Max", "John", "Mark"})} = Max, John and Mark like this");
        // Console.WriteLine($"{CWars.kyu6.Likes(new string[] {"Alex", "Jacob", "Mark", "Max"})} = Alex, Jacob and 2 others like this");


        // Codewars: Replace With Alphabet Position
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
        // Console.WriteLine($"Answer:   {CWars.kyu6.AlphabetPosition("The sunset sets at twelve o' clock.")} \nExpected: 20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11");
        // Console.WriteLine($"Answer:   {CWars.kyu6.AlphabetPosition("The narwhal bacons at midnight.")} \nExpected: 20 8 5 14 1 18 23 8 1 12 2 1 3 15 14 19 1 20 13 9 4 14 9 7 8 20");

        // Find the unique number
        // TODO : Fails random test?
        public static int GetUnique(IEnumerable<int> numbers)
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
        // Console.WriteLine($"Answer: {CWars.kyu6.ToCamelCase("the_stealth_warrior")} Expected: theStealthWarrior");
        // Console.WriteLine($"Answer: {CWars.kyu6.ToCamelCase("The-Stealth-Warrior")} Expected: TheStealthWarrior");
    }
}
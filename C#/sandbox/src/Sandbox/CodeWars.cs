namespace Sandbox
{
    public class CodeWars
    {
        public static string EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }

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

        public static string Disemvowel(string str)
        {
            if (str.Length > 0)
            {
                return str = str.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "").Replace("A", "").Replace("E", "").Replace("I", "").Replace("O", "").Replace("U", "");
            }
            else
            {
                return str;
            }
        }

        public static int SquareDigits(int n)
        {
            string nStr = n.ToString();
            string resultStr = "";
            for (int i = 0; i < n.ToString().Length; i++)
            {
                int num = (int)Char.GetNumericValue(nStr[i]);
                int calc = num * num;
                resultStr += calc.ToString();
            }
            return Int32.Parse(resultStr);
        }

        public static bool IsPrime(int n)
        {
            if (n == 2 || n == 3)
                return true;

            if (n <= 1 || n % 2 == 0 || n % 3 == 0)
                return false;

            for (int i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;
            }

            return true;
        }

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

        public static int[] Divisors(int n)
        {
            List<int> result = new List<int>();

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    result.Add(i);
                }
            }

            if (result.Count != 0)
            {
                int[] resultArray = new int[result.Count];

                for (int index = 0; index < result.Count; index++)
                {
                    resultArray[index] = result[index];
                }
                return resultArray;
            }
            else
            {
                return null;
            }
        }

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

        public static bool Scramble(string str1, string str2)
        {
            var countLetterStr1 = str1.GroupBy(ch => ch).ToDictionary(group => group.Key, group => group.Count());
            var countLetterStr2 = str2.GroupBy(ch => ch).ToDictionary(group => group.Key, group => group.Count());
            return countLetterStr2.All(letterCount => countLetterStr1.ContainsKey(letterCount.Key) && letterCount.Value <= countLetterStr1[letterCount.Key]);
        }

        public static int DigitalRoot(long n)
        {
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
    }
}
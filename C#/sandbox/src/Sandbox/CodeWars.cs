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
                    // System.Console.WriteLine($"i = {i}");
                    result.Add(i);
                }
            }
            // int testIndex = 1;
            // Console.WriteLine($"Value in Index 0: {result[0]}");
            // Console.WriteLine($"Value in Index testIndex: {result[testIndex]}");
            // Console.WriteLine($"Count: {result.Count}");

            if (result.Count != 0)
            {
                int[] resultArray = new int[result.Count];

                for (int index = 0; index < result.Count; index++)
                {
                    // System.Console.WriteLine($"Result at index {index}: {result[index]}");
                    resultArray[index] = result[index];
                    // System.Console.WriteLine($"Result at resultArray {index}: {resultArray[index]}");
                }
                return resultArray;
            } else {
                return null;    
            }
        }
    }
}
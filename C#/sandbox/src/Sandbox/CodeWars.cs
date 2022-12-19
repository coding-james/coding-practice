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
    }
}
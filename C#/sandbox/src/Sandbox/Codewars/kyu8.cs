namespace CWars
{
    public class kyu8
    {
        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        // CODEWARS: Convert a Number to a String!
        public static string NumberToString(int num)
        {
            return num.ToString();
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        // CODEWARS: Even or Odd
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

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        // CODEWARS: Rock Paper Scissors!
        public static string Rps(string p1, string p2)
        {
            if (p1 == p2)
                return "Draw!";

            if (((p1 == "rock") && (p2 == "scissors")) ||
                ((p1 == "scissors") && (p2 == "paper")) ||
                ((p1 == "paper") && (p2 == "rock")))
            {
                return "Player 1 won!";
            }
            else
            {
                return "Player 2 won!";
            }
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        // CODEWARS: Opposite Number
        public static int Opposite(int number)
        {
            return number - (number * 2);
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        // CODEWARS: Multiply
        public static int multiply(int a, int b)
        {
            return a * b;
        }
    }
}
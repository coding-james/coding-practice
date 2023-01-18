using System;

namespace MyMiniProjects
{
    public class simpleCalc
    {
        public static void SimpleCalc()
        {
            string answer;
            do
            {
                Console.WriteLine("\nEnter your first number:");
                int n1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your second number:");
                int n2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Select your operator (/,+,-,*)");
                string symbol = Console.ReadLine();

                switch (symbol)
                {
                    case "+":
                        Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
                        break;
                    case "-":
                        Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
                        break;
                    case "*":
                        Console.WriteLine($"{n1} * {n2} = {n1 * n2}");
                        break;
                    case "/":
                        Console.WriteLine($"{n1} / {n2} = {n1 / n2}");
                        break;
                    default:
                        Console.WriteLine("Please try again, make sure to enter a valid operator");
                        break;
                }
                Console.WriteLine("\nDo you want to continue (y/n)?");
                answer = Console.ReadLine();
            }
            while (answer.ToUpper() == "Y");
        }
    }
}
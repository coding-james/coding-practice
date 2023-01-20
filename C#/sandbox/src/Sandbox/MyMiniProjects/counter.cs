using System;

namespace MyMiniProjects
{
    public class counterC
    {
        public static void Counter()
        {
            string answer;
            int counter = 0;
            Console.WriteLine("\nEnter your counter increment:");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you want to increase or decrease (+,-)");
            string symbol = Console.ReadLine();

            do
            {
                if (symbol == "c")
                {
                    Console.WriteLine("\nEnter your counter increment:");
                    n1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Do you want to increase or decrease (+,-)");
                    symbol = Console.ReadLine();
                }

                switch (symbol)
                {
                    case "+":
                        counter += n1;
                        Console.WriteLine($"{counter}");
                        break;
                    case "-":
                        counter -= n1;
                        Console.WriteLine($"{counter}");
                        break;
                    default:
                        Console.WriteLine("Please try again, make sure to enter a valid operator");
                        break;
                }
                Console.WriteLine("\nDo you want to increase (+), decrease (-), change increment value (c) or exit (x)?");
                symbol = Console.ReadLine();
            }
            while (symbol.ToLower() == "c" || symbol == "+" || symbol == "-");
        }
    }
}
// MyMiniProjects.counterC.Counter();
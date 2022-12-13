// See https://aka.ms/new-console-template for more information

// Check for string arguments and customised greeting if true
// if (args.Length > 0)
// {
//     Console.WriteLine($"Hello {args[0]}!"); //dotnet run -- NAME
// }
// else
// {
//     Console.WriteLine($"Hello!"); //will run if no name (argument) given
// }

// A simple calculation
// double x = 34.1;
// double y = 10.3;
// Console.WriteLine(x + y);

// Looping through an Array
double[] numbers = new[] { 12.7, 10.3, 6.11 };
var result = 0.0;
foreach(double number in numbers) {
    result += number;
}
Console.WriteLine(result);
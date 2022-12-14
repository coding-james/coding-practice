﻿// See https://aka.ms/new-console-template for more information

// CHECK FOR STRING ARGUMENTS AND CUSTOMISE GREETING
// if (args.Length > 0)
// {
//     Console.WriteLine($"Hello {args[0]}!"); //dotnet run -- NAME
// }
// else
// {
//     Console.WriteLine($"Hello!"); //will run if no name (argument) given
// }

// A SIMPLE CALCULATION
// double x = 34.1;
// double y = 10.3;
// Console.WriteLine(x + y);

// LOOPING THROUGH AN ARRAY
// double[] numbers = new[] { 12.7, 10.3, 6.11 };
// var result = 0.0;
// foreach(double number in numbers) {
//     result += number;
// }
// Console.WriteLine(result);

// LISTS
List<double> grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 }; //Create List and add initial list values
grades.Add(56.1); //Add an entry to the list
var gradeResult = 0.0;
foreach(double number in grades) {
    gradeResult += number;
}
Console.WriteLine($"Total: {gradeResult}");
Console.WriteLine($"Average: {gradeResult / grades.Count:N2}"); //N2 formats to two decimal places
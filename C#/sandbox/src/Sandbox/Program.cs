// See https://aka.ms/new-console-template for more information

// OBJECTS AND CLASSES
Sandbox.Book book = new Sandbox.Book("Tony's GradeBook");
book.AddGrade(89.1);
book.AddGrade(90.5);
book.AddGrade(77.5);
var stats = book.GetStatistics();

Console.WriteLine($"--- GRADES ---\nTotal: {stats.Total} \nAverage: {stats.Average:N2} \nLowest: {stats.Low:N2} \nHighest: {stats.High:N2}"); //N2 formats to two decimal places

// CODEWARS CHECK
Console.WriteLine("CODEWARS:");
// Console.WriteLine(Sandbox.CodeWars.EvenOrOdd(4));
// Console.WriteLine(Sandbox.CodeWars.MultiOf3or5(10));
// Console.WriteLine(Sandbox.CodeWars.Disemvowel("This website is for losers LOL!"));
// Console.WriteLine(Sandbox.CodeWars.Disemvowel("No offense but,\nYour writing is among the worst I've ever read"));
// Console.WriteLine(Sandbox.CodeWars.Disemvowel("What are you, a communist?"));
// Console.WriteLine(Sandbox.CodeWars.SquareDigits(9119));
Console.WriteLine(Sandbox.CodeWars.IsPrime(0));
Console.WriteLine(Sandbox.CodeWars.IsPrime(1));
Console.WriteLine(Sandbox.CodeWars.IsPrime(2));
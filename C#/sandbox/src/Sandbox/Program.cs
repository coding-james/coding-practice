// See https://aka.ms/new-console-template for more information
if (args.Length > 0)
{
    Console.WriteLine($"Hello {args[0]}!"); //dotnet run -- NAME
}
else
{
    Console.WriteLine($"Hello!"); //will run if no name (argument) given
}

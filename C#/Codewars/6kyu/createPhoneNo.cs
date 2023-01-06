// CODEWARS - Create Phone Number

public class Kata
{
  public static string CreatePhoneNumber(int[] numbers)
  {
    return $"({string.Join("", numbers[0..3])}) {string.Join("", numbers[3..6])}-{string.Join("", numbers[6..10])}";  
  }
}

// Console.WriteLine($"{Sandbox.CodeWars.CreatePhoneNumber(new int[]{1,2,3,4,5,6,7,8,9,0})} = (123) 456-7890");
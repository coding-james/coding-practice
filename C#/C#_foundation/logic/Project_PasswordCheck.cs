using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      //Define password standards
      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "0123456789";
      string specialChars = "£$#-!";
      
      // check for weak passwords
      string weakPass1 = "password";
      string weakPass2 = "1234";

      Console.WriteLine("Create a password: ");
      string password = Console.ReadLine();

      int score = 0;

      if(password.Length >= minLength)
      {
        score++;
      }

      if(Tools.Contains(password, uppercase))
      {
        score++;
      }

      if(Tools.Contains(password, lowercase))
      {
        score++;
      }

      if(Tools.Contains(password, digits))
      {
        score++;
      }

      if(Tools.Contains(password, specialChars))
      {
        score++;
      }

      if(password == weakPass1 || password == weakPass2)
      {
        score = 0;
      }

      Console.WriteLine($"Password Core {score}");

      switch (score)
      {
        case 5:
        case 4:
          Console.WriteLine("the password is extremely strong");
          break;
        case 3:
          Console.WriteLine("the password is strong");
          break;
        case 2:
          Console.WriteLine("the password is medium");
          break;
        case 1:
          Console.WriteLine("the password is weak");
          break;
        default:
          Console.WriteLine("the password doesn't meet any standards");
          break;
      }
    }
  }
}
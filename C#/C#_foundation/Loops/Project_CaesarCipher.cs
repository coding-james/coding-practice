using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      
      Console.WriteLine("What is your message?");
      string msgString = Console.ReadLine().ToLower();
      char[] secretMessage = msgString.ToCharArray();
      char[] encryptedMessage = new char[secretMessage.Length];

      for (int i = 0; i < secretMessage.Length; i++)
      {
        char letter = secretMessage[i];
        int position = (Array.IndexOf(alphabet, letter) + 3) % alphabet.Length;
        Console.WriteLine($"{letter} = {position}");
        char encryptLetter = alphabet[position];
        encryptedMessage[i] = encryptLetter;
      }

      Console.WriteLine(String.Join("", encryptedMessage));      
    }
  }
}
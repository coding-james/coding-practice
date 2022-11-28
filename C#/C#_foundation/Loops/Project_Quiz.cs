using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      // Type your code below
      string[] questions = {"It is possible to sneeze while sleeping", "The capital of Spain is Madrid", "Mt. Everest is the highest mountain in the world."};

      bool[] answers = {false, true, true};

      bool[] responses = new bool[questions.Length];

      if( questions.Length != answers.Length) 
      {
        Console.WriteLine("WARNING: There are a different number of Questions and Answers");
      }

      int askingIndex = 0;

      foreach (string question in questions)
      {
        string input;
        bool isBool;
        bool inputBool;

        Console.WriteLine(question);
        Console.WriteLine("is this true or false?");
        input = Console.ReadLine();
        isBool = Boolean.TryParse(input, out inputBool);

        while (isBool == false){
          Console.WriteLine("is this true or false?");
          input = Console.ReadLine();
          isBool = Boolean.TryParse(input, out inputBool);
        }

        responses[askingIndex] = inputBool;
        askingIndex++;
      }
      
      Console.WriteLine(String.Join(", ", responses));
      
      int scoringIndex = 0;
      int score = 0;

      foreach(bool response in responses)
      {
        bool responseCheck = responses[scoringIndex];
        Console.WriteLine($"{scoringIndex + 1}. Input: {responseCheck} | Answer: {answers[scoringIndex]}");
        if (responseCheck == answers[scoringIndex])
        {
          score++;
        }
        scoringIndex++;
      }

      Console.WriteLine($"You got {score} of {questions.Length} correct");
    }
  }
}
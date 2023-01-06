// Codewars - Rock Paper Scissors!

public class Kata
{
  public string Rps(string p1, string p2)
  {
    if (p1 == p2)
      return "Draw!";

    if (((p1 == "rock") && (p2 == "scissors")) ||
        ((p1 == "scissors") && (p2 == "paper")) ||
        ((p1 == "paper") && (p2 == "rock")))
    {
      return "Player 1 won!";
    }
    else
    {
      return "Player 2 won!";
    }
  }
}

// Console.WriteLine($"{Sandbox.CodeWars.Rps("rock", "scissors")} = Player 1 won!");
// Console.WriteLine($"{Sandbox.CodeWars.Rps("scissors", "paper")} = Player 1 won!");
// Console.WriteLine($"{Sandbox.CodeWars.Rps("paper", "rock")} = Player 1 won!");

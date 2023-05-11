using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Codewars.kyu8
{
    public class RockPaperScissors
    {
        // CODEWARS: Rock Paper Scissors!
        public static string Rps(string p1, string p2)
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
}

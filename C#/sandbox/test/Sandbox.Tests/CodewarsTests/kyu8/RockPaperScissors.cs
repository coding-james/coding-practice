using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu8
{
    public class RockPaperScissors
    {
        // CODEWARS: Rock Paper Scissors!
        [Theory]
        [InlineData("Player 1 won!", "rock", "scissors")]
        [InlineData("Player 1 won!", "scissors", "paper")]
        [InlineData("Player 1 won!", "paper", "rock")]
        [InlineData("Draw!", "paper", "paper")]
        [InlineData("Player 2 won!", "scissors", "rock")]

        public void Rps(string expected, string player1, string player2)
        {
            Assert.Equal(expected, Codewars.kyu8.RockPaperScissors.Rps(player1, player2));
        }
    }
}

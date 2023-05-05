using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu4
{
    // CODEWARS: Connect 4
    public class Connect4
    {
        [Fact]
        public void YellowWins()
        {
            List<string> input = new List<string> { "A_Red", "B_Yellow", "A_Red", "B_Yellow", "A_Red", "B_Yellow", "G_Red", "B_Yellow" };
            Assert.Equal("Yellow", Codewars.kyu4.Connect4.WhoIsWinner(input));
        }

        [Fact]
        public void YellowWins_LongGame()
        {
            List<string> input = new List<string> { "C_Yellow", "E_Red", "G_Yellow", "B_Red", "D_Yellow", "B_Red", "B_Yellow", "G_Red", "C_Yellow", "C_Red", "D_Yellow", "F_Red", "E_Yellow", "A_Red", "A_Yellow", "G_Red", "A_Yellow", "F_Red", "F_Yellow", "D_Red", "B_Yellow", "E_Red", "D_Yellow", "A_Red", "G_Yellow", "D_Red", "D_Yellow", "C_Red" };
            Assert.Equal("Yellow", Codewars.kyu4.Connect4.WhoIsWinner(input));
        }

        [Fact]
        public void RedWins()
        {
            List<string> input = new List<string> { "A_Yellow", "B_Red", "B_Yellow", "C_Red", "G_Yellow", "C_Red", "C_Yellow", "D_Red", "G_Yellow", "D_Red", "G_Yellow", "D_Red", "F_Yellow", "E_Red", "D_Yellow" };
            Assert.Equal("Red", Codewars.kyu4.Connect4.WhoIsWinner(input));
        }

        [Fact]
        public void RedWins_FirstToFour()
        {
            List<string> input = new List<string> { "A_Red", "B_Yellow", "A_Red", "B_Yellow", "A_Red", "B_Yellow", "A_Red", "B_Yellow" };
            Assert.Equal("Red", Codewars.kyu4.Connect4.WhoIsWinner(input));
        }

        [Fact]
        public void YellowWins_JustYellow()
        {
            List<string> input = new List<string> { "B_Yellow", "B_Yellow", "B_Yellow", "B_Yellow" };
            Assert.Equal("Yellow", Codewars.kyu4.Connect4.WhoIsWinner(input));
        }

        [Fact]
        public void Draw()
        {
            List<string> input = new List<string> { "A_Red", "B_Yellow", "A_Red", "B_Yellow", "A_Red", "B_Yellow", "G_Red", "G_Yellow" };
            Assert.Equal("Draw", Codewars.kyu4.Connect4.WhoIsWinner(input));
        }
    }
}

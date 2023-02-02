namespace Sandbox.Tests
{
    public class kyu8
    {
        // CODEWARS: Convert a Number to a String!
        [Theory]
        [InlineData("123", 123)]
        [InlineData("0", 0)]
        [InlineData("999888", 999888)]

        public void NumberToString(string expected, int input)
        {
            Assert.Equal(expected, CWars.kyu8.NumberToString(input));
        }


        // CODEWARS: Even or Odd
        [Theory]
        [InlineData("Even", 4)]
        [InlineData("Even", 12)]
        [InlineData("Odd", 25)]
        [InlineData("Odd", 15)]
        [InlineData("Even", 16)]
        [InlineData("Odd", 253)]
        [InlineData("Even", 24)]

        public void EvenOrOdd(string expected, int input)
        {
            Assert.Equal(expected, CWars.kyu8.EvenOrOdd(input));
        }


        // CODEWARS: Rock Paper Scissors!
        [Theory]
        [InlineData("Player 1 won!", "rock", "scissors")]
        [InlineData("Player 1 won!", "scissors", "paper")]
        [InlineData("Player 1 won!", "paper", "rock")]
        [InlineData("Draw!", "paper", "paper")]
        [InlineData("Player 2 won!", "scissors", "rock")]

        public void Rps(string expected, string player1, string player2)
        {
            Assert.Equal(expected, CWars.kyu8.Rps(player1, player2));
        }

        
        // CODEWARS: Opposite Number
        [Theory]
        [InlineData(-1, 1)]
        [InlineData(-14, 14)]
        [InlineData(34, -34)]

        public void Opposite(int expected, int input)
        {
            Assert.Equal(expected, CWars.kyu8.Opposite(input));
        }


        // CODEWARS: Multiply
        [Theory]
        [InlineData(10, 5, 2)]
        [InlineData(15, 5, 3)]
        [InlineData(0, 5, 0)]

        public void multiply(int expected, int input1, int input2)
        {
            Assert.Equal(expected, CWars.kyu8.multiply(input1, input2));
        }
    }
}
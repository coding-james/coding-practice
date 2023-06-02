using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu8
{
    public class EvenOrOdds
    {
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
            Assert.Equal(expected, Codewars.kyu8.EvenOrOdds.EvenOrOdd(input));
        }
    }
}

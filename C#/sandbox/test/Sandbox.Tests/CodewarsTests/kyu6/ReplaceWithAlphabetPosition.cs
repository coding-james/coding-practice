using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu6
{
    public class ReplaceWithAlphabetPosition
    {
        // CODEWARS: Replace With Alphabet Position
        [Theory]
        [InlineData("20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11", "The sunset sets at twelve o' clock.")]
        [InlineData("20 8 5 14 1 18 23 8 1 12 2 1 3 15 14 19 1 20 13 9 4 14 9 7 8 20", "The narwhal bacons at midnight.")]

        public void AlphabetPosition(string expected, string input)
        {
            Assert.Equal(expected, Codewars.kyu6.ReplaceWithAlphabetPosition.AlphabetPosition(input));
        }
    }
}

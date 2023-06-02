using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu7
{
    public class YoureASquare
    {
        // CODEWARS: You're a square!
        [Theory]
        [InlineData(false, -1)]
        [InlineData(true, 0)]
        [InlineData(false, 3)]
        [InlineData(true, 4)]
        [InlineData(true, 25)]
        [InlineData(false, 26)]
        [InlineData(false, 605493)]

        public void IsSquare(bool expected, int input)
        {
            Assert.Equal(expected, Codewars.kyu7.YoureASquare.IsSquare(input));
        }
    }
}

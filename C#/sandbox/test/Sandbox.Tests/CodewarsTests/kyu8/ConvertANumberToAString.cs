using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu8
{
    public class ConvertANumberToAString
    {
        // CODEWARS: Convert a Number to a String!
        [Theory]
        [InlineData("123", 123)]
        [InlineData("0", 0)]
        [InlineData("999888", 999888)]

        public void NumberToString(string expected, int input)
        {
            Assert.Equal(expected, Codewars.kyu8.ConvertANumberToAString.NumberToString(input));
        }
    }
}

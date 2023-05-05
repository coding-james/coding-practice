using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu5
{
    public class ValidParentheses
    {
        // CODEWARS: Valid Parentheses
        [Theory]
        [InlineData(true, "()")]
        [InlineData(false, ")(()))")]
        [InlineData(false, "(")]
        [InlineData(true, "(())((()())())")]

        public void Solution(bool expected, string input)
        {
            Assert.Equal(expected, Codewars.kyu5.ValidParentheses.Solution(input));
        }
    }
}

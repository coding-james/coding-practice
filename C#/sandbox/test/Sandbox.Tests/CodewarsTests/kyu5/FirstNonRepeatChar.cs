using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu5
{
    public class FirstNonRepeatChar
    {
        // CODEWARS: First non-repeating character
        [Theory]
        [InlineData("a", "a")]
        [InlineData("t", "stress")]
        [InlineData("t", "StRess")]
        [InlineData("e", "moonmen")]
        [InlineData("", "")]
        [InlineData("", "aaaaaa")]
        [InlineData("", "Aaaaaa")]

        public void FirstNonRepeatingLetter(string expected, string input)
        {
            Assert.Equal(expected, Codewars.kyu5.FirstNonRepeatChar.FirstNonRepeatingLetter(input));
        }
    }
}

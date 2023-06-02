using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu6
{
    public class RomanNumeralsEncoder
    {
        // CODEWARS: Roman Numerals Encoder
        [Theory]
        [InlineData("I", 1)]
        [InlineData("II", 2)]
        [InlineData("IV", 4)]
        [InlineData("D", 500)]
        [InlineData("M", 1000)]
        [InlineData("MCMLIV", 1954)]
        [InlineData("MCMXC", 1990)]
        [InlineData("MMVIII", 2008)]
        [InlineData("MMXIV", 2014)]

        public void RomanConvert(string expected, int input)
        {
            Assert.Equal(expected, Codewars.kyu6.RomanNumeralsEncoder.RomanConvert(input));
        }
    }
}

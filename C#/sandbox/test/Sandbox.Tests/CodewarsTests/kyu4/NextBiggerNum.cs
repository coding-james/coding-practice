using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu4
{
    public class NextBiggerNum
    {
        // CODEWARS: Next bigger number with the same digits
        [Theory]
        [InlineData(21, 12)]
        [InlineData(531, 513)]
        [InlineData(2071, 2017)]
        [InlineData(441, 414)]
        [InlineData(414, 144)]
        [InlineData(-1, 9)]
        [InlineData(-1, 111)]
        [InlineData(-1, 531)]
        [InlineData(1234567908, 1234567890)]
        [InlineData(960315268, 960312865)]

        public void NextBiggerNumber(long expected, long input)
        {
            Assert.Equal(expected, Codewars.kyu4.NextBiggerNum.NextBiggerNumber(input));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu8
{
    public class OppositeNumber
    {
        // CODEWARS: Opposite Number
        [Theory]
        [InlineData(-1, 1)]
        [InlineData(-14, 14)]
        [InlineData(34, -34)]

        public void Opposite(int expected, int input)
        {
            Assert.Equal(expected, Codewars.kyu8.OppositeNumber.Opposite(input));
        }
    }
}

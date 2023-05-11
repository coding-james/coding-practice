using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu8
{
    public class Multiplier
    {
        // CODEWARS: Multiply
        [Theory]
        [InlineData(10, 5, 2)]
        [InlineData(15, 5, 3)]
        [InlineData(0, 5, 0)]

        public void multiply(int expected, int input1, int input2)
        {
            Assert.Equal(expected, Codewars.kyu8.Multiplier.multiply(input1, input2));
        }
    }
}

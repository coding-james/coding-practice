using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu6
{
    public class SumOfDigits
    {
        // CODEWARS: Sum of Digits / Digital Root
        [Theory]
        [InlineData(7, 16)]
        [InlineData(6, 456)]
        [InlineData(6, 132189)]
        [InlineData(2, 493193)]

        public void DigitalRoot(int expected, long input)
        {
            Assert.Equal(expected, Codewars.kyu6.SumOfDigits.DigitalRoot(input));
        }
    }
}

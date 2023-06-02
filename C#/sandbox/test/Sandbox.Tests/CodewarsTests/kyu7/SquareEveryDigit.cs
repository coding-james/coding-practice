using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu7
{
    public class SquareEveryDigit
    {
        // CODEWARS: Square Every Digit / Digit*Digit
        [Fact]
        public void SquareDigits() => Assert.Equal(811181, Codewars.kyu7.SquareEveryDigit.SquareDigits(9119));
    }
}

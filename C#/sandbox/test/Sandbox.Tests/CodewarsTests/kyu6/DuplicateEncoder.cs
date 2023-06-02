using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu6
{
    public class DuplicateEncoder
    {
        // CODEWARS: Duplicate Encoder
        [Theory]
        [InlineData("(((", "din")]
        [InlineData("()()()", "recede")]
        [InlineData(")())())", "Success")]
        [InlineData("))((", "(( @")]

        public void DuplicateEncode(string expected, string input)
        {
            Assert.Equal(expected, Codewars.kyu6.DuplicateEncoder.DuplicateEncode(input));
        }
    }
}

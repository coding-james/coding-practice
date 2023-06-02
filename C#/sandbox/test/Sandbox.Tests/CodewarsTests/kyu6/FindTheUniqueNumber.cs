using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu6
{
    public class FindTheUniqueNumber
    {
        // CODEWARS: Find the unique number
        [Theory]
        [InlineData(1, new[] { 1, 2, 2, 2 })]
        [InlineData(-2, new[] { -2, 2, 2, 2 })]
        [InlineData(14, new[] { 11, 11, 14, 11, 11 })]
        [InlineData(14, new[] { 11, 11, 14, 11, 11, 11, 11, 11, 11, 11 })]
        [InlineData(14, new[] { 11, 11, 11, 11, 11, 11, 11, 11, 11, 14 })]

        public void GetUnique(int expected, IEnumerable<int> input)
        {
            Assert.Equal(expected, Codewars.kyu6.FindTheUniqueNumber.GetUnique(input));
        }
    }
}

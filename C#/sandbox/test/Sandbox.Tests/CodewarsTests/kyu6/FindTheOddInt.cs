using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu6
{
    public class FindTheOddInt
    {
        // CODEWARS: Find the odd int
        [Theory]
        [InlineData(7, new int[] { 7 })]
        [InlineData(0, new int[] { 0 })]
        [InlineData(2, new int[] { 1, 1, 2 })]
        [InlineData(0, new int[] { 0, 1, 0, 1, 0 })]
        [InlineData(4, new int[] { 1, 2, 2, 3, 3, 3, 4, 3, 3, 3, 2, 2, 1 })]

        public void find_it(int expected, int[] input)
        {
            Assert.Equal(expected, Codewars.kyu6.FindTheOddInt.find_it(input));
        }
    }
}

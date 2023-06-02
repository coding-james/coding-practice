using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu7
{
    public class FindTheDivisors
    {
        // CODEWARS: Find the divisors!
        [Theory]
        [InlineData(new int[] { 2, 3, 4, 6 }, 12)]
        [InlineData(new int[] { 5 }, 25)]
        [InlineData(new int[] { 3, 5 }, 15)]
        [InlineData(new int[] { 2, 4, 8 }, 16)]
        [InlineData(new int[] { 11, 23 }, 253)]
        [InlineData(new int[] { 2, 3, 4, 6, 8, 12 }, 24)]

        public void Divisors(int[] expected, int input1)
        {
            Assert.Equal(expected, Codewars.kyu7.FindTheDivisors.Divisors(input1));
        }
    }
}

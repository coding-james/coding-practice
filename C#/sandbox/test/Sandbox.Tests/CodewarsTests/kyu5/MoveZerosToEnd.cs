using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu5
{
    public class MoveZerosToEnd
    {
        // CODEWARS: Moving Zeros To The End
        [Theory]
        [InlineData(new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 }, new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 0, 0, 0 }, new int[] { 1, 2, 0, 3, 4, 5, 6, 0, 0, 7 })]
        [InlineData(new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 })]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]

        public void MoveZeros(int[] expected, int[] input)
        {
            Assert.Equal(expected, Codewars.kyu5.MoveZerosToEnd.MoveZeroes(input));
        }
    }
}

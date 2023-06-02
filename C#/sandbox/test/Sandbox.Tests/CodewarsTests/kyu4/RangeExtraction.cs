using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu4
{
    public class RangeExtraction
    {
        // CODEWARS: Range Extraction
        [Theory]
        [InlineData("1,2", new int[] { 1, 2 })]
        [InlineData("1-3", new int[] { 1, 2, 3 })]
        [InlineData("-6,-3-1,3-5,7-11,14,15,17-20", new int[] { -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20 })]
        [InlineData("-3--1,2,10,15,16,18-20", new int[] { -3, -2, -1, 2, 10, 15, 16, 18, 19, 20 })]
        [InlineData("-10--8,-6,-3-1,3-5,7-11,14,15,17-20", new int[] { -10, -9, -8, -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20 })]

        public void Extract(string expected, int[] input)
        {
            Assert.Equal(expected, Codewars.kyu4.RangeExtraction.Extract(input));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu6
{
    public class FindTheParityOutlier
    {
        // CODEWARS: Find the Parity Outlier
        [Theory]
        [InlineData(3, new int[] { 2, 6, 8, -10, 3 })]
        [InlineData(206847684, new int[] { 206847684, 1056521, 7, 17, 1901, 21104421, 7, 1, 35521, 1, 7781 })]
        [InlineData(0, new int[] { int.MaxValue, 0, 1 })]

        public void Find(int expected, int[] input)
        {
            Assert.Equal(expected, Codewars.kyu6.FindTheParityOutlier.Find(input));
        }
    }
}

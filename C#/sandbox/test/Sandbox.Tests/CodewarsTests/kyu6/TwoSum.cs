using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu6
{
    public class TwoSum
    {
        // CODEWARS: Two Sum
        [Theory]
        [InlineData(new int[] { 0, 2 }, new[] { 1, 2, 3 }, 4)]
        [InlineData(new int[] { 1, 2 }, new[] { 1234, 5678, 9012 }, 14690)]
        [InlineData(new int[] { 0, 1 }, new[] { 2, 2, 3 }, 4)]

        public void TwoSumTest(int[] expected, int[] input, int target)
        {
            Assert.Equal(expected, Codewars.kyu6.TwoSum.TwoSumSolution(input, target));
        }
    }
}

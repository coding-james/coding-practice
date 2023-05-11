using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu6
{
    public class ArrayDiff
    {
        // CODEWARS: Array.diff
        [Theory]
        [InlineData(new int[] { 2 }, new int[] { 1, 2 }, new int[] { 1 })]
        [InlineData(new int[] { 2, 2 }, new int[] { 1, 2, 2 }, new int[] { 1 })]
        [InlineData(new int[] { 1 }, new int[] { 1, 2, 2 }, new int[] { 2 })]
        [InlineData(new int[] { }, new int[] { }, new int[] { 1, 2 })]
        [InlineData(new int[] { 3 }, new int[] { 1, 2, 3 }, new int[] { 1, 2 })]
        public void ArrayCompare(int[] expected, int[] input1, int[] input2)
        {
            Assert.Equal(expected, Codewars.kyu6.ArrayDiff.ArrayCompare(input1, input2));
        }
    }
}

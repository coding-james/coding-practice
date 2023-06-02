using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu6
{
    public class CountingDuplicates
    {
        // CODEWARS: Counting Duplicates
        [Theory]
        [InlineData(0, "")]
        [InlineData(0, "abcde")]
        [InlineData(2, "aabbcde")]
        [InlineData(2, "aabBcde")]
        [InlineData(1, "Indivisibility")]
        [InlineData(2, "Indivisibilities")]

        public void DuplicateCount(int expected, string input)
        {
            Assert.Equal(expected, Codewars.kyu6.CountingDuplicates.DuplicateCount(input));
        }
    }
}

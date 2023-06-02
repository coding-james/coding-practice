using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu6
{
    public class TakeATenMinWalk
    {
        // CODEWARS: Take a Ten Minute Walk
        [Theory]
        [InlineData(true, new string[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" })]
        [InlineData(false, new string[] { "w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e" })]
        [InlineData(false, new string[] { "w" })]
        [InlineData(false, new string[] { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" })]

        public void IsValidWalk(bool expected, string[] input)
        {
            Assert.Equal(expected, Codewars.kyu6.TakeATenMinWalk.IsValidWalk(input));
        }
    }
}

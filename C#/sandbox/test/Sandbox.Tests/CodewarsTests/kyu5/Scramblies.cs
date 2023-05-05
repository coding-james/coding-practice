using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu5
{
    public class Scramblies
    {
        // CODEWARS: Scramblies
        [Theory]
        [InlineData(true, "rkqodlw", "world")]
        [InlineData(true, "cedewaraaossoqqyt", "codewars")]
        [InlineData(false, "katas", "steak")]
        [InlineData(false, "scriptjavx", "javascript")]
        [InlineData(true, "scriptingjava", "javascript")]
        [InlineData(true, "scriptsjava", "javascripts")]
        [InlineData(false, "javscripts", "javascript")]
        [InlineData(true, "aabbcamaomsccdd", "commas")]
        [InlineData(true, "commas", "commas")]
        [InlineData(true, "sammoc", "commas")]

        public void scramble(bool expected, string input1, string input2)
        {
            Assert.Equal(expected, Codewars.kyu5.Scramblies.Scramble(input1, input2));
        }
    }
}

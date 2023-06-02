using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu4
{
    // CODEWARS: Human readable duration format
    public class HumanReadableFormat
    {
        [Theory]
        [InlineData("now", 0)]
        [InlineData("1 second", 1)]
        [InlineData("1 minute and 2 seconds", 62)]
        [InlineData("2 minutes", 120)]
        [InlineData("1 hour, 1 minute and 2 seconds", 3662)]
        [InlineData("182 days, 1 hour, 44 minutes and 40 seconds", 15731080)]
        [InlineData("4 years, 68 days, 3 hours and 4 minutes", 132030240)]
        [InlineData("6 years, 192 days, 13 hours, 3 minutes and 54 seconds", 205851834)]
        [InlineData("8 years, 12 days, 13 hours, 41 minutes and 1 second", 253374061)]
        [InlineData("7 years, 246 days, 15 hours, 32 minutes and 54 seconds", 242062374)]
        [InlineData("3 years, 85 days, 1 hour, 9 minutes and 26 seconds", 101956166)]
        [InlineData("1 year, 19 days, 18 hours, 19 minutes and 46 seconds", 33243586)]

        public void formatDuration(string expected, int actual)
        {
            Assert.Equal(expected, Sandbox.Codewars.kyu4.HumanReadableFormat.formatDuration(actual));
        }
    }
}

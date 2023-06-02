using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu5
{
    public class HumanReadableTime
    {
        // CODEWARS: Human Readable Time
        [Theory]
        [InlineData("00:00:00", 0)]
        [InlineData("00:00:05", 5)]
        [InlineData("00:01:00", 60)]
        [InlineData("23:59:59", 86399)]
        [InlineData("99:59:59", 359999)]
        public void GetReadableTime(string expected, int input)
        {
            Assert.Equal(expected, Codewars.kyu5.HumanReadableTime.GetReadableTime(input));
        }
    }
}

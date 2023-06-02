using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu5
{
    public class LetsPlayDarts
    {
        // CODEWARS: Let's Play Darts
        [Theory]
        [InlineData("X", -133.69d, -147.38d)]
        [InlineData("DB", 4.06d, 0.71d)]
        [InlineData("SB", 2.38d, -6.06d)]
        [InlineData("20", -5.43d, 117.95d)]
        [InlineData("7", -73.905d, -95.94d)]
        [InlineData("T2", 55.53d, -87.95d)]
        [InlineData("D9", -145.19d, 86.53d)]

        public void GetScore(string expected, double inputX, double inputY)
        {
            Assert.Equal(expected, Codewars.kyu5.LetsPlayDarts.GetScore(inputX, inputY));
        }
    }
}

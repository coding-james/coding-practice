using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu5
{
    public class DirectionsReduction
    {
        // CODEWARS: Directions Reduction
        [Theory]
        [InlineData(new string[] { "SOUTH", "WEST", "WEST" }, new string[] { "NORTH", "SOUTH", "SOUTH", "WEST", "WEST" })]
        [InlineData(new string[] { }, new string[] { "NORTH", "SOUTH", "EAST", "WEST" })]
        [InlineData(new string[] { "WEST" }, new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" })]

        public void dirReduc(string[] expected, string[] input)
        {
            Assert.Equal(expected, Codewars.kyu5.DirectionsReduction.dirReduc(input));
        }
    }
}

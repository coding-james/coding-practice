using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu6
{
    public class WhoLikesIt
    {
        // CODEWARS: Who likes it?
        [Theory]
        [InlineData("no one likes this", new string[0])]
        [InlineData("Peter likes this", new string[] { "Peter" })]
        [InlineData("Jacob and Alex like this", new string[] { "Jacob", "Alex" })]
        [InlineData("Max, John and Mark like this", new string[] { "Max", "John", "Mark" })]
        [InlineData("Alex, Jacob and 2 others like this", new string[] { "Alex", "Jacob", "Mark", "Max" })]

        public void Likes(string expected, string[] input)
        {
            Assert.Equal(expected, Codewars.kyu6.WhoLikesIt.Likes(input));
        }
    }
}

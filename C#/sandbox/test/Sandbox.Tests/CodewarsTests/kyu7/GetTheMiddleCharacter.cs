using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu7
{
    public class GetTheMiddleCharacter
    {
        // CODEWARS: Get the Middle Character
        [Theory]
        [InlineData("es", "test")]
        [InlineData("t", "testing")]
        [InlineData("dd", "middle")]
        [InlineData("A", "A")]


        public void GetMiddle(string expected, string input)
        {
            Assert.Equal(expected, Codewars.kyu7.GetTheMiddleCharacter.GetMiddle(input));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu6
{
    public class ConvertStringToCamelCase
    {
        // CODEWARS: Convert string to camel case
        [Theory]
        [InlineData("theStealthWarrior", "the_stealth_warrior")]
        [InlineData("TheStealthWarrior", "The-Stealth-Warrior")]

        public void ToCamelCase(string expected, string input)
        {
            Assert.Equal(expected, Codewars.kyu6.ConvertStringToCamelCase.ToCamelCase(input));
        }
    }
}

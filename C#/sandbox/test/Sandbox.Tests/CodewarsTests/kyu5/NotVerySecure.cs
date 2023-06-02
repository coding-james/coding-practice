using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu5
{
    public class NotVerySecure
    {
        // CODEWARS: Not Very Secure
        [Theory]
        [InlineData(true, "Mazinkaiser")]
        [InlineData(false, "hello world_")]
        [InlineData(true, "PassW0rd")]
        [InlineData(false, "     ")]
        [InlineData(false, "")]

        public void Alphanumeric(bool expected, string input)
        {
            Assert.Equal(expected, Codewars.kyu5.NotVerySecure.Alphanumeric(input));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu5
{
    public class CountIpAddress
    {
        // CODEWARS: Count IP Addresses
        [Theory]
        [InlineData(50, "10.0.0.0", "10.0.0.50")]
        [InlineData(246, "20.0.0.10", "20.0.1.0")]
        [InlineData(256, "20.0.0.0", "20.0.1.0")]

        public void IpsBetween(int expected, string input1, string input2)
        {
            Assert.Equal(expected, Codewars.kyu5.CountIpAddress.IpsBetween(input1, input2));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu7
{
    public class DescendingOrder
    {
        // CODEWARS: Descending Order
        [Theory]
        [InlineData(0, 0)]
        [InlineData(54421, 42145)]
        [InlineData(654321, 145263)]
        [InlineData(987654321, 123456789)]

        public void DescOrder(int expected, int input)
        {
            Assert.Equal(expected, Codewars.kyu7.DescendingOrder.DescOrder(input));
        }
    }
}

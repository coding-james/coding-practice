using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu4
{
    public class SumStringAsNum
    {
        // Codewars: Sum Strings as Numbers
        [Theory]
        [InlineData("579", "123", "456")]
        [InlineData("468", "12", "456")]
        [InlineData("5444", "5123", "321")]
        [InlineData("8987", "99", "8888")]
        [InlineData("10098", "9999", "99")]

        public void sumStrings(string expected, string input1, string input2) => Assert.Equal(expected, Sandbox.Codewars.kyu4.SumStringAsNum.sumStrings(input1, input2));
    }
}

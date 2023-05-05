using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu4
{
    // CODEWARS: Adding Big Numbers
    public class AddingBigNum
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            string a = "91";
            string b = "19";
            string expected = "110";

            // Act
            string actual = Codewars.kyu4.AddingBigNum.Add(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal("1111111111", Codewars.kyu4.AddingBigNum.Add("123456789", "987654322"));
        }

        [Fact]
        public void Test3()
        {
            Assert.Equal("1000000000", Codewars.kyu4.AddingBigNum.Add("999999999", "1"));
        }
    }
}

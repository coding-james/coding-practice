using Xunit;
// TODO: take a look at https://stackoverflow.com/questions/42467244/xunit-and-multiple-data-records-for-a-test
// https://learn.microsoft.com/en-us/visualstudio/test/walkthrough-creating-and-running-unit-tests-for-managed-code?view=vs-2022

namespace Sandbox.Tests
{
    public class kyu4 
    {
        public class AddBigNumbers
        {
            [Fact]
            public void Test1()
            {
                // Arrange
                string a = "91";
                string b = "19";
                string expected = "110";

                // Act
                string actual = CWars.kyu4.Add(a, b);

                // Assert
                Assert.Equal(expected, actual);
            }

            [Fact]
            public void Test2()
            {
                Assert.Equal("1111111111", CWars.kyu4.Add("123456789", "987654322"));
            }

            [Fact]
            public void Test3()
            {
                Assert.Equal("1000000000", CWars.kyu4.Add("999999999", "1"));
            }
        }

        // CODEWARS: Human readable duration format
        [Theory]
        [InlineData("now", 0)]
        [InlineData("1 second", 1)]
        [InlineData("1 minute and 2 seconds", 62)]
        [InlineData("2 minutes", 120)]
        [InlineData("1 hour, 1 minute and 2 seconds", 3662)]
        [InlineData("182 days, 1 hour, 44 minutes and 40 seconds", 15731080)]
        [InlineData("4 years, 68 days, 3 hours and 4 minutes", 132030240)]
        [InlineData("6 years, 192 days, 13 hours, 3 minutes and 54 seconds", 205851834)]
        [InlineData("8 years, 12 days, 13 hours, 41 minutes and 1 second", 253374061)]
        [InlineData("7 years, 246 days, 15 hours, 32 minutes and 54 seconds", 242062374)]
        [InlineData("3 years, 85 days, 1 hour, 9 minutes and 26 seconds", 101956166)]
        [InlineData("1 year, 19 days, 18 hours, 19 minutes and 46 seconds", 33243586)]

        public void formatDuration(string expected, int actual)
        {
            Assert.Equal(expected, CWars.kyu4.formatDuration(actual));
        }

        // Codewars: Sum Strings as Numbers
        [Theory]
        [InlineData("579", "123", "456")]
        [InlineData("468", "12", "456")]
        [InlineData("5444", "5123", "321")]
        [InlineData("8987", "99", "8888")]
        [InlineData("10098", "9999", "99")]

        public void sumStrings(string expected, string input1, string input2) => Assert.Equal(expected, CWars.kyu4.sumStrings(input1, input2));
    }
}
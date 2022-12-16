using Xunit;

namespace Sandbox.Tests

{
    public class BookTests
    {
        [Fact]
        public void ExampleTests()
        {
            // Arrange Section
            var x = 5;
            var y = 2;
            var expected = 10;

            // Act Section
            var actual = x * y;

            // Assert Section
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UnitTestGetStatistics()
        {
            // Arrange Section
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            // Act Section
            var results = book.GetStatistics();

            // Assert Section
            Assert.Equal(85.6, results.Average, 1); //3rd Parameter is to how many decimal places
            Assert.Equal(90.5, results.High, 1);
            Assert.Equal(77.3, results.Low, 1);
        }
    }
}
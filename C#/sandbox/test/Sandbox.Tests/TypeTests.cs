using Xunit;

namespace Sandbox.Tests

{
    public class TypeTests
    {
        [Fact]
        public void TestNameOnCreation()
        {
            // Arrange Section
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            // Act Section


            // Assert Section
            Assert.Equal("Book 1", book1.Name);
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            // Arrange Section
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            // Act Section


            // Assert Section
            Assert.Equal("New Name", book1.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnDifferentObjects()
        {
            // Arrange Section
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            // Act Section


            // Assert Section
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            // Arrange Section
            var book1 = GetBook("Book 1");
            var book2 = book1;

            // Act Section


            // Assert Section
            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2)); //Does same as Same
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
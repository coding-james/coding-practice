namespace Sandbox.Tests
{
    public class kyu7
    {
        // CODEWARS: Disemvowel Trolls
        [Theory]
        [InlineData("Ths wbst s fr lsrs LL!", "This website is for losers LOL!")]
        [InlineData("N ffns bt,\nYr wrtng s mng th wrst 'v vr rd", "No offense but,\nYour writing is among the worst I've ever read")]
        [InlineData("Wht r y,  cmmnst?", "What are you, a communist?")]

        public void Disemvowel(string expected, string input1)
        {
            Assert.Equal(expected, CWars.kyu7.Disemvowel(input1));
        }


        // CODEWARS: Find the divisors!
        [Theory]
        [InlineData(new int[] { 2, 3, 4, 6 }, 12)]
        [InlineData(new int[] { 5 }, 25)]
        [InlineData(new int[] { 3, 5 }, 15)]
        [InlineData(new int[] { 2, 4, 8 }, 16)]
        [InlineData(new int[] { 11, 23 }, 253)]
        [InlineData(new int[] { 2, 3, 4, 6, 8, 12 }, 24)]

        public void Divisors(int[] expected, int input1)
        {
            Assert.Equal(expected, CWars.kyu7.Divisors(input1));
        }


        // CODEWARS: You're a square!
        [Theory]
        [InlineData(false, -1)]
        [InlineData(true, 0)]
        [InlineData(false, 3)]
        [InlineData(true, 4)]
        [InlineData(true, 25)]
        [InlineData(false, 26)]
        [InlineData(false, 605493)]

        public void IsSquare(bool expected, int input)
        {
            Assert.Equal(expected, CWars.kyu7.IsSquare(input));
        }


        // CODEWARS: Square Every Digit / Digit*Digit
        [Fact]
        public void SquareDigits() => Assert.Equal(811181, CWars.kyu7.SquareDigits(9119));


        // CODEWARS: Vowel Count
        [Fact]
        public void GetVowelCount() => Assert.Equal(2, CWars.kyu7.GetVowelCount("hello"));


        // CODEWARS: Get the Middle Character
        [Theory]
        [InlineData("es", "test")]
        [InlineData("t", "testing")]
        [InlineData("dd", "middle")]
        [InlineData("A", "A")]


        public void GetMiddle(string expected, string input)
        {
            Assert.Equal(expected, CWars.kyu7.GetMiddle(input));
        }


        // CODEWARS: Descending Order
        [Theory]
        [InlineData(0, 0)]
        [InlineData(54421, 42145)]
        [InlineData(654321, 145263)]
        [InlineData(987654321, 123456789)]

        public void DescendingOrder(int expected, int input)
        {
            Assert.Equal(expected, CWars.kyu7.DescendingOrder(input));
        }
    }
}
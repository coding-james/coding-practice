namespace Sandbox.Tests
{
    public class kyu6
    {
        // CODEWARS: Take a Ten Minute Walk
        [Theory]
        [InlineData(true, new string[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" })]
        [InlineData(false, new string[] { "w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e" })]
        [InlineData(false, new string[] { "w" })]
        [InlineData(false, new string[] { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" })]

        public void IsValidWalk(bool expected, string[] input1)
        {
            Assert.Equal(expected, CWars.kyu6.IsValidWalk(input1));
        }

        // CODEWARS: Array.diff
        [Theory]
        [InlineData(new int[] { 2 }, new int[] { 1, 2 }, new int[] { 1 })]
        [InlineData(new int[] { 2, 2 }, new int[] { 1, 2, 2 }, new int[] { 1 })]
        [InlineData(new int[] { 1 }, new int[] { 1, 2, 2 }, new int[] { 2 })]
        [InlineData(new int[] { }, new int[] { }, new int[] { 1, 2 })]
        [InlineData(new int[] { 3 }, new int[] { 1, 2, 3 }, new int[] { 1, 2 })]
        public void ArrayDiff(int[] expected, int[] input1, int[] input2)
        {
            Assert.Equal(expected, CWars.kyu6.ArrayDiff(input1, input2));
        }


        // CODEWARS: Counting Duplicates
        [Theory]
        [InlineData(0, "")]
        [InlineData(0, "abcde")]
        [InlineData(2, "aabbcde")]
        [InlineData(2, "aabBcde")]
        [InlineData(1, "Indivisibility")]
        [InlineData(2, "Indivisibilities")]

        public void DuplicateCount(int expected, string input)
        {
            Assert.Equal(expected, CWars.kyu6.DuplicateCount(input));
        }

        // CODEWARS: Create Phone Number
        [Fact]
        public void CreatePhoneNumber() => Assert.Equal("(123) 456-7890", CWars.kyu6.CreatePhoneNumber(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }));

        // CODEWARS: Sum of Digits / Digital Root
        [Theory]
        [InlineData(7, 16)]
        [InlineData(6, 456)]
        [InlineData(6, 132189)]
        [InlineData(2, 493193)]

        public void DigitalRoot(int expected, long input)
        {
            Assert.Equal(expected, CWars.kyu6.DigitalRoot(input));
        }

        // CODEWARS: Duplicate Encoder
        [Theory]
        [InlineData("(((", "din")]
        [InlineData("()()()", "recede")]
        [InlineData(")())())", "Success")]
        [InlineData("))((", "(( @")]

        public void DuplicateEncode(string expected, string input)
        {
            Assert.Equal(expected, CWars.kyu6.DuplicateEncode(input));
        }

        // CODEWARS: Find the odd int
        [Theory]
        [InlineData(7, new int[] {7})]
        [InlineData(0, new int[] {0})]
        [InlineData(2, new int[] {1,1,2})]
        [InlineData(0, new int[] {0,1,0,1,0})]
        [InlineData(4, new int[] {1,2,2,3,3,3,4,3,3,3,2,2,1})]

        public void find_it(int expected, int[] input)
        {
            Assert.Equal(expected, CWars.kyu6.find_it(input));
        }

        // CODEWARS: Find the Parity Outlier
        [Theory]
        [InlineData(3, new int[] {2,6,8,-10,3})]
        [InlineData(206847684, new int[] {206847684,1056521,7,17,1901,21104421,7,1,35521,1,7781})]
        [InlineData(0, new int[] { int.MaxValue, 0, 1 })]

        public void Find(int expected, int[] input)
        {
            Assert.Equal(expected, CWars.kyu6.Find(input));
        }

        // CODEWARS: Is a number prime?
        [Theory]
        [InlineData(false, 0)]
        [InlineData(false, 1)]
        [InlineData(true, 2)]

        public void IsPrime(bool expected, int input)
        {
            Assert.Equal(expected, CWars.kyu6.IsPrime(input));
        }

        // CODEWARS: Mutliple of 3 or 5
        [Fact]
        public void MultiOf3or5() => Assert.Equal(23, CWars.kyu6.MultiOf3or5(10));

        // CODEWARS: Who likes it?
        [Theory]
        [InlineData("no one likes this", new string[0])]
        [InlineData("Peter likes this", new string[] {"Peter"})]
        [InlineData("Jacob and Alex like this", new string[] {"Jacob", "Alex"})]
        [InlineData("Max, John and Mark like this", new string[] {"Max", "John", "Mark"})]
        [InlineData("Alex, Jacob and 2 others like this", new string[] {"Alex", "Jacob", "Mark", "Max"})]

        public void Likes(string expected, string[] input)
        {
            Assert.Equal(expected, CWars.kyu6.Likes(input));
        }

        // CODEWARS: Replace With Alphabet Position
        [Theory]
        [InlineData("20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11", "The sunset sets at twelve o' clock.")]
        [InlineData("20 8 5 14 1 18 23 8 1 12 2 1 3 15 14 19 1 20 13 9 4 14 9 7 8 20", "The narwhal bacons at midnight.")]

        public void AlphabetPosition(string expected, string input)
        {
            Assert.Equal(expected, CWars.kyu6.AlphabetPosition(input));
        }

        // CODEWARS: Find the unique number
        [Theory]
        [InlineData(1, new [] {1, 2, 2, 2})]
        [InlineData(-2, new [] {-2, 2, 2, 2})]
        [InlineData(14, new [] {11, 11, 14, 11, 11})]
        [InlineData(14, new [] {11, 11, 14, 11, 11, 11, 11, 11, 11, 11})]
        [InlineData(14, new [] {11, 11, 11, 11, 11, 11, 11, 11, 11, 14})]

        public void GetUnique(int expected, IEnumerable<int> input)
        {
            Assert.Equal(expected, CWars.kyu6.GetUnique(input));
        }

        // CODEWARS: Convert string to camel case
        [Theory]
        [InlineData("theStealthWarrior", "the_stealth_warrior")]
        [InlineData("TheStealthWarrior", "The-Stealth-Warrior")]

        public void ToCamelCase(string expected, string input)
        {
            Assert.Equal(expected, CWars.kyu6.ToCamelCase(input));
        }

        // CODEWARS: Roman Numerals Encoder
        [Theory]
        [InlineData("I", 1)]
        [InlineData("II", 2)]
        [InlineData("IV", 4)]
        [InlineData("D", 500)]
        [InlineData("M", 1000)]
        [InlineData("MCMLIV", 1954)]
        [InlineData("MCMXC", 1990)]
        [InlineData("MMVIII", 2008)]
        [InlineData("MMXIV", 2014)]

        public void RomanConvert(string expected, int input)
        {
            Assert.Equal(expected, CWars.kyu6.RomanConvert(input));
        }

        // CODEWARS: Two Sum
        [Theory]
        [InlineData(new int[] {0,2}, new [] { 1, 2, 3 }, 4)]
        [InlineData(new int[] {1,2}, new [] { 1234, 5678, 9012 }, 14690)]
        [InlineData(new int[] {0,1}, new [] { 2, 2, 3 }, 4)]

        public void TwoSum(int[] expected, int[] input, int target)
        {
            Assert.Equal(expected, CWars.kyu6.TwoSum(input, target));
        }
        
        // CODEWARS: Split Strings
        [Theory]
        [InlineData(new string[] {"ab", "c_"}, "abc")]
        [InlineData(new string[] {"ab", "cd", "ef"}, "abcdef")]


        public void SplitString(string[] expected, string input)
        {
            Assert.Equal(expected, CWars.kyu6.SplitString(input));
        }
    }
}
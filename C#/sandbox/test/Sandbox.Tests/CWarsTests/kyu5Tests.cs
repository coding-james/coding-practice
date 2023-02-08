namespace Sandbox.Tests
{
    public class kyu5
    {
        // CODEWARS: Scramblies
        [Theory]
        [InlineData(true, "rkqodlw","world")]
        [InlineData(true, "cedewaraaossoqqyt","codewars")]
        [InlineData(false, "katas","steak")]
        [InlineData(false, "scriptjavx","javascript")]
        [InlineData(true, "scriptingjava","javascript")]
        [InlineData(true, "scriptsjava","javascripts")]
        [InlineData(false, "javscripts","javascript")]
        [InlineData(true, "aabbcamaomsccdd","commas")]
        [InlineData(true, "commas","commas")]
        [InlineData(true, "sammoc","commas")]

        public void scramble(bool expected, string input1, string input2)
        {
            Assert.Equal(expected, CWars.kyu5.Scramble(input1, input2));
        }

        // CODEWARS: Human Readable Time
        [Theory]
        [InlineData("00:00:00", 0)]
        [InlineData("00:00:05", 5)]
        [InlineData("00:01:00", 60)]
        [InlineData("23:59:59", 86399)]
        [InlineData("99:59:59", 359999)]
        public void GetReadableTime(string expected, int input)
        {
            Assert.Equal(expected, CWars.kyu5.GetReadableTime(input));
        }


        // CODEWARS: Count IP Addresses
        [Theory]
        [InlineData(50, "10.0.0.0", "10.0.0.50")]
        [InlineData(246, "20.0.0.10", "20.0.1.0")]
        [InlineData(256, "20.0.0.0", "20.0.1.0")]

        public void IpsBetween(int expected, string input1, string input2)
        {
            Assert.Equal(expected, CWars.kyu5.IpsBetween(input1, input2));
        }

        // CODEWARS: Moving Zeros To The End
        [Theory]
        [InlineData(new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 }, new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 0, 0, 0 }, new int[] { 1, 2, 0, 3, 4, 5, 6, 0, 0, 7 })]
        [InlineData(new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 })]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]

        public void MoveZeros(int[] expected, int[] input)
        {
            Assert.Equal(expected, CWars.kyu5.MoveZeroes(input));
        }

        // CODEWARS: Let's Play Darts
        [Theory]
        [InlineData("X", -133.69d, -147.38d)]
        [InlineData("DB", 4.06d, 0.71d)]
        [InlineData("SB", 2.38d, -6.06d)]
        [InlineData("20", -5.43d, 117.95d)]
        [InlineData("7", -73.905d, -95.94d)]
        [InlineData("T2", 55.53d, -87.95d)]
        [InlineData("D9", -145.19d, 86.53d)]

        public void GetScore(string expected, double inputX, double inputY)
        {
            Assert.Equal(expected, CWars.kyu5.GetScore(inputX, inputY));
        }
    }
}
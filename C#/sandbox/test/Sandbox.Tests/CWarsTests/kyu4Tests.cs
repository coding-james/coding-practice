using Sandbox.Codewars.kyu4;
using Xunit;
// TODO: take a look at https://stackoverflow.com/questions/42467244/xunit-and-multiple-data-records-for-a-test
// https://learn.microsoft.com/en-us/visualstudio/test/walkthrough-creating-and-running-unit-tests-for-managed-code?view=vs-2022
using Interval = System.ValueTuple<int, int>;

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

        // CODEWARS: Next bigger number with the same digits
        [Theory]
        [InlineData(21, 12)]
        [InlineData(531, 513)]
        [InlineData(2071, 2017)]
        [InlineData(441, 414)]
        [InlineData(414, 144)]
        [InlineData(-1, 9)]
        [InlineData(-1, 111)]
        [InlineData(-1, 531)]
        [InlineData(1234567908, 1234567890)]
        [InlineData(960315268, 960312865)]

        public void NextBiggerNumber(long expected, long input)
        {
            Assert.Equal(expected, CWars.kyu4.NextBiggerNumber(input));
        }

        // CODEWARS: Range Extraction
        [Theory]
        [InlineData("1,2", new int[] {1,2})]
        [InlineData("1-3", new int[] { 1, 2, 3 })]
        [InlineData("-6,-3-1,3-5,7-11,14,15,17-20", new int[] { -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20 })]
        [InlineData("-3--1,2,10,15,16,18-20", new int[] { -3, -2, -1, 2, 10, 15, 16, 18, 19, 20 })]
        [InlineData("-10--8,-6,-3-1,3-5,7-11,14,15,17-20", new int[] { -10, -9, -8, -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20 })]

        public void Extract(string expected, int[] input)
        {
            Assert.Equal(expected, CWars.kyu4.Extract(input));
        }

        public class SumOfCWars
        {
            // CODEWARS: Sum of Intervals
            [Fact]
            public void ShouldHandleEmptyIntervals()
            {
                Assert.Equal(0, CWars.kyu4.SumIntervals(new Interval[] { }));
                Assert.Equal(0, CWars.kyu4.SumIntervals(new Interval[] { (4, 4), (6, 6), (8, 8) }));
            }

            [Fact]
            public void ShouldAddDisjoinedIntervals()
            {
                Assert.Equal(9, CWars.kyu4.SumIntervals(new Interval[] { (1, 2), (6, 10), (11, 15) }));
                Assert.Equal(11, CWars.kyu4.SumIntervals(new Interval[] { (4, 8), (9, 10), (15, 21) }));
                Assert.Equal(7, CWars.kyu4.SumIntervals(new Interval[] { (-1, 4), (-5, -3) }));
                Assert.Equal(78, CWars.kyu4.SumIntervals(new Interval[] { (-245, -218), (-194, -179), (-155, -119) }));
            }

            [Fact]
            public void ShouldAddAdjacentIntervals()
            {
                Assert.Equal(54, CWars.kyu4.SumIntervals(new Interval[] { (1, 2), (2, 6), (6, 55) }));
                Assert.Equal(23, CWars.kyu4.SumIntervals(new Interval[] { (-2, -1), (-1, 0), (0, 21) }));
            }

            [Fact]
            public void ShouldAddOverlappingIntervals()
            {
                Assert.Equal(7, CWars.kyu4.SumIntervals(new Interval[] { (1, 4), (7, 10), (3, 5) }));
                Assert.Equal(6, CWars.kyu4.SumIntervals(new Interval[] { (5, 8), (3, 6), (1, 2) }));
                Assert.Equal(19, CWars.kyu4.SumIntervals(new Interval[] { (1, 5), (10, 20), (1, 6), (16, 19), (5, 11) }));
            }

            [Fact]
            public void ShouldHandleMixedIntervals()
            {
                Assert.Equal(13, CWars.kyu4.SumIntervals(new Interval[] { (2, 5), (-1, 2), (-40, -35), (6, 8) }));
                Assert.Equal(1234, CWars.kyu4.SumIntervals(new Interval[] { (-7, 8), (-2, 10), (5, 15), (2000, 3150), (-5400, -5338) }));
                Assert.Equal(158, CWars.kyu4.SumIntervals(new Interval[] { (-101, 24), (-35, 27), (27, 53), (-105, 20), (-36, 26) }));
            }

            [Fact]
            public void ShouldHandleLargeIntervals()
            {
                Assert.Equal(2_000_000_000, CWars.kyu4.SumIntervals(new Interval[] { (-1_000_000_000, 1_000_000_000) }));
                Assert.Equal(100_000_030, CWars.kyu4.SumIntervals(new Interval[] { (0, 20), (-100_000_000, 10), (30, 40) }));
            }

            [Fact]
            public void ShouldHandleSmallRandomIntervals()
            {
                Assert.Equal(18, CWars.kyu4.SumIntervals(new Interval[] { (-216, -198), (-211, -203) }));
                Assert.Equal(18, CWars.kyu4.SumIntervals(new Interval[] { (-211, -203), (-216, -198) }));
                Assert.Equal(188, CWars.kyu4.SumIntervals(new Interval[] { (-216, -198), (400, 402), (-417, -409), (-179, -176), (427, 438), (-211, -203), (-107, -87), (31, 39), (433, 442), (-115, -113), (-358, -345), (-370, -353), (104, 119), (417, 433), (352, 364), (-71, -59), (461, 469), (-303, -294), (191, 205), (-452, -445) }));
            }

            [Fact]
            public void ShouldHandleLargeRandomIntervals()
            {
                Assert.Equal(461476477, CWars.kyu4.SumIntervals(new Interval[] { (-573528343, -571443363), (-404938234, -396893974), (-247571308, -238405012), (-630492169, -622051206), (-954703734, -951452445), (16977492, 26384115), (-46420694, -37011236), (25182514, 29886867), (927981456, 937720825), (635518698, 640898831), (893880536, 895402307), (789961613, 793176771), (-661958883, -660707722), (-225081790, -215429208), (-744126808, -738583557), (-671908501, -667796544), (13735989, 16822008), (-142362877, -136590466), (-176574521, -175124974), (-542581752, -534579489), (-958525369, -954868609), (-641501655, -631680661), (623564313, 629895314), (-358451001, -357238595), (623042781, 628743187), (-301469560, -292579480), (637244718, 643336245), (762711780, 769192762), (807266386, 810716075), (695230808, 701289613), (964324701, 973735567), (-767828304, -766096865), (950040452, 959392007), (-28145107, -21437885), (-716947927, -711542037), (-122305075, -114684576), (642159714, 646197638), (-295854353, -293828857), (-565968776, -560100007), (559690829, 564602559), (-123545469, -121841837), (267746742, 274847034), (716228515, 724349487), (-481079162, -471982827), (319316845, 320752658), (-338273878, -330550502), (419632788, 425361538), (535957971, 542161340), (676975262, 681299647), (-658082407, -649132895), (745130308, 747968138), (-287561072, -279283181), (940154513, 942117860), (-742655783, -732714073), (298901660, 306999992), (247151253, 256528874), (156737087, 166460027), (-659285928, -649332820), (532869533, 535480692), (583179549, 584591226), (737146021, 744977839), (-562188862, -555352730), (-516257678, -510870225), (-322867347, -316380159), (-731898428, -729884390), (949186102, 957537853), (-88265906, -78710731), (-93289935, -86477806), (-521761810, -512713449), (-410338618, -407902713), (804939463, 811140715), (174837828, 176593930), (-103434715, -98735003), (574033874, 582937262), (189222990, 195697627), (681982011, 684059949), (-239589707, -232418724), (79826651, 85064036), (-801800449, -793565620), (117364838, 126714305), (841093585, 849668073), (557415525, 560819039), (627921265, 634696106), (-816689836, -810345159), (-124856019, -119756628), (61297258, 68096981), (-236607103, -234943462), (-122425504, -118035993) }));
            }
        }

        // CODEWARS: Most frequently used words in a text
        public class Top3Words
        {
            [Fact]
            public void SampleTests()
            {
                Assert.Equal(new List<string> { "house", "cat" }, freqWords.Top3("house house house house cat cat cat"));
                Assert.Equal(new List<string> { "house", "cat", "dog" }, freqWords.Top3("house house house house cat cat cat dog dog elephant"));
                Assert.Equal(new List<string> { "house", "cat", "dog" }, freqWords.Top3("elephant dog dog cat cat cat house house house house"));
                Assert.Equal(new List<string> { "house", "cat", "dog" }, freqWords.Top3("house  house  house  house  cat  cat  cat  dog  dog  elephant"));
                Assert.Equal(new List<string> { "house", "cat" }, freqWords.Top3("house house house house HOUSE cat cat cat CAT"));
                Assert.Equal(new List<string> { "house", "cat" }, freqWords.Top3("house house house house #cat cat cat"));
                Assert.Equal(new List<string> { "won't", "wont", "dog" }, freqWords.Top3("won't won't won't won't wont wont wont dog dog elephant"));
                Assert.Equal(new List<string> { "house", "cat", "dog" }, freqWords.Top3("house house house house \ncat cat cat dog dog elephant"));
                Assert.Equal(new List<string> { "e", "d", "a" }, freqWords.Top3("a a a  b  c c  d d d d  e e e e e"));
                Assert.Equal(new List<string> { "e", "ddd", "aa" }, freqWords.Top3("e e e e DDD ddd DdD: ddd ddd aa aA Aa, bb cc cC e e e"));
                Assert.Equal(new List<string> { "won't", "wont" }, freqWords.Top3("  //wont won't won't "));
                Assert.Equal(new List<string> { "e" }, freqWords.Top3("  , e   .. "));
                Assert.Equal(new List<string> { }, freqWords.Top3("  ...  "));
                Assert.Equal(new List<string> { }, freqWords.Top3("  '  "));
                Assert.Equal(new List<string> { }, freqWords.Top3("  '''  "));
                Assert.Equal(new List<string> { "a", "of", "on" }, freqWords.Top3(
                    string.Join("\n", new string[]{"In a village of La Mancha, the name of which I have no desire to call to",
                  "mind, there lived not long since one of those gentlemen that keep a lance",
                  "in the lance-rack, an old buckler, a lean hack, and a greyhound for",
                  "coursing. An olla of rather more beef than mutton, a salad on most",
                  "nights, scraps on Saturdays, lentils on Fridays, and a pigeon or so extra",
                  "on Sundays, made away with three-quarters of his income." })));
            }
        }

        // CODEWARS: Roman Numerals Helper
        public class RomanNumerals
        {
            [Theory]
            [InlineData(1, "I")]
            [InlineData(2, "II")]
            [InlineData(4, "IV")]
            [InlineData(5, "V")]
            [InlineData(10, "X")]
            [InlineData(21, "XXI")]
            [InlineData(25, "XXV")]
            [InlineData(50, "L")]
            [InlineData(100, "C")]
            [InlineData(500, "D")]
            [InlineData(1000, "M")]
            [InlineData(2000, "MM")]
            [InlineData(3000, "MMM")]
            [InlineData(1954, "MCMLIV")]
            [InlineData(1990, "MCMXC")]
            [InlineData(2008, "MMVIII")]
            [InlineData(2014, "MMXIV")]

            public void RomanNumerals_To_Roman(int input, string expected)
            {
                Assert.Equal(expected, Codewars.kyu4.romanNumeralHelper.ToRoman(input));
            }

            [Theory]
            [InlineData(1, "I")]
            [InlineData(2, "II")]
            [InlineData(4, "IV")]
            [InlineData(5, "V")]
            [InlineData(10, "X")]
            [InlineData(21, "XXI")]
            [InlineData(25, "XXV")]
            [InlineData(50, "L")]
            [InlineData(100, "C")]
            [InlineData(500, "D")]
            [InlineData(1000, "M")]
            [InlineData(2000, "MM")]
            [InlineData(3000, "MMM")]
            [InlineData(1954, "MCMLIV")]
            [InlineData(1990, "MCMXC")]
            [InlineData(2008, "MMVIII")]
            [InlineData(2014, "MMXIV")]

            public void RomanNumerals_From_Roman(int expected, string input)
            {
                Assert.Equal(expected, Codewars.kyu4.romanNumeralHelper.FromRoman(input));
            }
        }
    }
}
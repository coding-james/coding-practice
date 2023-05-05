using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interval = System.ValueTuple<int, int>;

namespace Sandbox.Tests.CodewarsTests.kyu4
{
    public class SumOfIntervals
    {
        // CODEWARS: Sum of Intervals
        [Fact]
        public void ShouldHandleEmptyIntervals()
        {
            Assert.Equal(0, Codewars.kyu4.SunOfIntervals.SumIntervals(new Interval[] { }));
            Assert.Equal(0, Codewars.kyu4.SunOfIntervals.SumIntervals(new Interval[] { (4, 4), (6, 6), (8, 8) }));
        }

        [Fact]
        public void ShouldAddDisjoinedIntervals()
        {
            Assert.Equal(9, Codewars.kyu4.SunOfIntervals.SumIntervals(new Interval[] { (1, 2), (6, 10), (11, 15) }));
            Assert.Equal(11, Codewars.kyu4.SunOfIntervals.SumIntervals(new Interval[] { (4, 8), (9, 10), (15, 21) }));
            Assert.Equal(7, Codewars.kyu4.SunOfIntervals.SumIntervals(new Interval[] { (-1, 4), (-5, -3) }));
            Assert.Equal(78, Codewars.kyu4.SunOfIntervals.SumIntervals(new Interval[] { (-245, -218), (-194, -179), (-155, -119) }));
        }

        [Fact]
        public void ShouldAddAdjacentIntervals()
        {
            Assert.Equal(54, Codewars.kyu4.SunOfIntervals.SumIntervals(new Interval[] { (1, 2), (2, 6), (6, 55) }));
            Assert.Equal(23, Codewars.kyu4.SunOfIntervals.SumIntervals(new Interval[] { (-2, -1), (-1, 0), (0, 21) }));
        }

        [Fact]
        public void ShouldAddOverlappingIntervals()
        {
            Assert.Equal(7, Codewars.kyu4.SunOfIntervals.SumIntervals(new Interval[] { (1, 4), (7, 10), (3, 5) }));
            Assert.Equal(6, Codewars.kyu4.SunOfIntervals.SumIntervals(new Interval[] { (5, 8), (3, 6), (1, 2) }));
            Assert.Equal(19, Codewars.kyu4.SunOfIntervals.SumIntervals(new Interval[] { (1, 5), (10, 20), (1, 6), (16, 19), (5, 11) }));
        }

        [Fact]
        public void ShouldHandleMixedIntervals()
        {
            Assert.Equal(13, Codewars.kyu4.SunOfIntervals.SumIntervals(new Interval[] { (2, 5), (-1, 2), (-40, -35), (6, 8) }));
            Assert.Equal(1234, Codewars.kyu4.SunOfIntervals.SumIntervals(new Interval[] { (-7, 8), (-2, 10), (5, 15), (2000, 3150), (-5400, -5338) }));
            Assert.Equal(158, Codewars.kyu4.SunOfIntervals.SumIntervals(new Interval[] { (-101, 24), (-35, 27), (27, 53), (-105, 20), (-36, 26) }));
        }

        [Fact]
        public void ShouldHandleLargeIntervals()
        {
            Assert.Equal(2_000_000_000, Codewars.kyu4.SunOfIntervals.SumIntervals(new Interval[] { (-1_000_000_000, 1_000_000_000) }));
            Assert.Equal(100_000_030, Codewars.kyu4.SunOfIntervals.SumIntervals(new Interval[] { (0, 20), (-100_000_000, 10), (30, 40) }));
        }

        [Fact]
        public void ShouldHandleSmallRandomIntervals()
        {
            Assert.Equal(18, Codewars.kyu4.SunOfIntervals.SumIntervals(new Interval[] { (-216, -198), (-211, -203) }));
            Assert.Equal(18, Codewars.kyu4.SunOfIntervals.SumIntervals(new Interval[] { (-211, -203), (-216, -198) }));
            Assert.Equal(188, Codewars.kyu4.SunOfIntervals.SumIntervals(new Interval[] { (-216, -198), (400, 402), (-417, -409), (-179, -176), (427, 438), (-211, -203), (-107, -87), (31, 39), (433, 442), (-115, -113), (-358, -345), (-370, -353), (104, 119), (417, 433), (352, 364), (-71, -59), (461, 469), (-303, -294), (191, 205), (-452, -445) }));
        }

        [Fact]
        public void ShouldHandleLargeRandomIntervals()
        {
            Assert.Equal(461476477, Codewars.kyu4.SunOfIntervals.SumIntervals(new Interval[] { (-573528343, -571443363), (-404938234, -396893974), (-247571308, -238405012), (-630492169, -622051206), (-954703734, -951452445), (16977492, 26384115), (-46420694, -37011236), (25182514, 29886867), (927981456, 937720825), (635518698, 640898831), (893880536, 895402307), (789961613, 793176771), (-661958883, -660707722), (-225081790, -215429208), (-744126808, -738583557), (-671908501, -667796544), (13735989, 16822008), (-142362877, -136590466), (-176574521, -175124974), (-542581752, -534579489), (-958525369, -954868609), (-641501655, -631680661), (623564313, 629895314), (-358451001, -357238595), (623042781, 628743187), (-301469560, -292579480), (637244718, 643336245), (762711780, 769192762), (807266386, 810716075), (695230808, 701289613), (964324701, 973735567), (-767828304, -766096865), (950040452, 959392007), (-28145107, -21437885), (-716947927, -711542037), (-122305075, -114684576), (642159714, 646197638), (-295854353, -293828857), (-565968776, -560100007), (559690829, 564602559), (-123545469, -121841837), (267746742, 274847034), (716228515, 724349487), (-481079162, -471982827), (319316845, 320752658), (-338273878, -330550502), (419632788, 425361538), (535957971, 542161340), (676975262, 681299647), (-658082407, -649132895), (745130308, 747968138), (-287561072, -279283181), (940154513, 942117860), (-742655783, -732714073), (298901660, 306999992), (247151253, 256528874), (156737087, 166460027), (-659285928, -649332820), (532869533, 535480692), (583179549, 584591226), (737146021, 744977839), (-562188862, -555352730), (-516257678, -510870225), (-322867347, -316380159), (-731898428, -729884390), (949186102, 957537853), (-88265906, -78710731), (-93289935, -86477806), (-521761810, -512713449), (-410338618, -407902713), (804939463, 811140715), (174837828, 176593930), (-103434715, -98735003), (574033874, 582937262), (189222990, 195697627), (681982011, 684059949), (-239589707, -232418724), (79826651, 85064036), (-801800449, -793565620), (117364838, 126714305), (841093585, 849668073), (557415525, 560819039), (627921265, 634696106), (-816689836, -810345159), (-124856019, -119756628), (61297258, 68096981), (-236607103, -234943462), (-122425504, -118035993) }));
        }
    }
}

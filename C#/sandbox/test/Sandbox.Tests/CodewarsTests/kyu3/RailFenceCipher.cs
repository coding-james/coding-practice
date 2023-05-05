using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu3
{
    public class RailFenceCipher
    {
        // CODEWARS: Rail Fence Cipher: Encoding and Decoding
        [Theory]
        [InlineData("WECRLTEERDSOEEFEAOCAIVDEN", "WEAREDISCOVEREDFLEEATONCE", 3)]
        [InlineData("Hoo!el,Wrdl l", "Hello, World!", 3)]
        [InlineData("H !e,Wdloollr", "Hello, World!", 4)]
        [InlineData("", "", 3)]
        [InlineData("ABC", "ABC", 3)]
        [InlineData("AB", "AB", 2)]
        [InlineData("Tacotvyohtakhua eea dt b slhyi wIa t t dwolt  yyhtou' uehed aei ovd bahoidy yyeeg tt s 'wo  sot  a erou,sit'asbgher woltnnlowot hAomaaoyeuon gtnnee dbetnneo d hrd of  abna yo oId yu nbw yo", "Today is gonna be the day that they're gonna throw it back to you And by now, you should've somehow realised what you gotta do I don't believe that anybody feels the way I do about you now", 15)]
        [InlineData("T'yieaoyrbnlsivobdeedoaeledoahgnwedetIuytoA,rwbhytitnuywhtaaysanoooa'twoghayuhtnaeuottoseyonhnnyhthmodytonarkoouIbswadocusgoolbewaleoddeehibdvtayett'tf", "Todayisgonnabethedaythatthey'regonnathrowitbacktoyouAndbynow,youshould'vesomehowrealisedwhatyougottadoIdon'tbelievethatanybodyfeelsthewayIdoaboutyounow", 15)]

        public void RailFenceCipher_Encode(string expected, string input1, int input2)
        {
            Assert.Equal(expected, Codewars.kyu3.RailFenceCipher.Encode(input1, input2));
        }

        [Theory]
        [InlineData("WEAREDISCOVEREDFLEEATONCE", "WECRLTEERDSOEEFEAOCAIVDEN", 3)]
        [InlineData("Hello, World!", "Hoo!el,Wrdl l", 3)]
        [InlineData("Hello, World!", "H !e,Wdloollr", 4)]
        [InlineData("", "", 3)]
        [InlineData("ABC", "ABC", 3)]
        [InlineData("AB", "AB", 2)]
        [InlineData("Today is gonna be the day that they're gonna throw it back to you And by now, you should've somehow realised what you gotta do I don't believe that anybody feels the way I do about you now", "Tacotvyohtakhua eea dt b slhyi wIa t t dwolt  yyhtou' uehed aei ovd bahoidy yyeeg tt s 'wo  sot  a erou,sit'asbgher woltnnlowot hAomaaoyeuon gtnnee dbetnneo d hrd of  abna yo oId yu nbw yo", 15)]
        [InlineData("Todayisgonnabethedaythatthey'regonnathrowitbacktoyouAndbynow,youshould'vesomehowrealisedwhatyougottadoIdon'tbelievethatanybodyfeelsthewayIdoaboutyounow", "T'yieaoyrbnlsivobdeedoaeledoahgnwedetIuytoA,rwbhytitnuywhtaaysanoooa'twoghayuhtnaeuottoseyonhnnyhthmodytonarkoouIbswadocusgoolbewaleoddeehibdvtayett'tf", 15)]

        public void RailFenceCipher_Decode(string expected, string input1, int input2)
        {
            Assert.Equal(expected, Codewars.kyu3.RailFenceCipher.Decode(input1, input2));
        }
    }
}

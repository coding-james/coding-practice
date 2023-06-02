using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu7
{
    public class DisemvowelTrolls
    {
        // CODEWARS: Disemvowel Trolls
        [Theory]
        [InlineData("Ths wbst s fr lsrs LL!", "This website is for losers LOL!")]
        [InlineData("N ffns bt,\nYr wrtng s mng th wrst 'v vr rd", "No offense but,\nYour writing is among the worst I've ever read")]
        [InlineData("Wht r y,  cmmnst?", "What are you, a communist?")]

        public void Disemvowel(string expected, string input1)
        {
            Assert.Equal(expected, Codewars.kyu7.DisemvowelTrolls.Disemvowel(input1));
        }
    }
}

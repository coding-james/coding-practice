using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu7
{
    public class VowelCount
    {
        // CODEWARS: Vowel Count
        [Fact]
        public void GetVowelCount() => Assert.Equal(2, Codewars.kyu7.VowelCount.GetVowelCount("hello"));
    }
}

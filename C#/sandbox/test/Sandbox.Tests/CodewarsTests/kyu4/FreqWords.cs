using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu4
{
    // CODEWARS: Most frequently used words in a text
    public class FreqWords
    {
        [Fact]
        public void SampleTests()
        {
            Assert.Equal(new List<string> { "house", "cat" }, Codewars.kyu4.FreqWords.Top3("house house house house cat cat cat"));
            Assert.Equal(new List<string> { "house", "cat", "dog" }, Codewars.kyu4.FreqWords.Top3("house house house house cat cat cat dog dog elephant"));
            Assert.Equal(new List<string> { "house", "cat", "dog" }, Codewars.kyu4.FreqWords.Top3("elephant dog dog cat cat cat house house house house"));
            Assert.Equal(new List<string> { "house", "cat", "dog" }, Codewars.kyu4.FreqWords.Top3("house  house  house  house  cat  cat  cat  dog  dog  elephant"));
            Assert.Equal(new List<string> { "house", "cat" }, Codewars.kyu4.FreqWords.Top3("house house house house HOUSE cat cat cat CAT"));
            Assert.Equal(new List<string> { "house", "cat" }, Codewars.kyu4.FreqWords.Top3("house house house house #cat cat cat"));
            Assert.Equal(new List<string> { "won't", "wont", "dog" }, Codewars.kyu4.FreqWords.Top3("won't won't won't won't wont wont wont dog dog elephant"));
            Assert.Equal(new List<string> { "house", "cat", "dog" }, Codewars.kyu4.FreqWords.Top3("house house house house \ncat cat cat dog dog elephant"));
            Assert.Equal(new List<string> { "e", "d", "a" }, Codewars.kyu4.FreqWords.Top3("a a a  b  c c  d d d d  e e e e e"));
            Assert.Equal(new List<string> { "e", "ddd", "aa" }, Codewars.kyu4.FreqWords.Top3("e e e e DDD ddd DdD: ddd ddd aa aA Aa, bb cc cC e e e"));
            Assert.Equal(new List<string> { "won't", "wont" }, Codewars.kyu4.FreqWords.Top3("  //wont won't won't "));
            Assert.Equal(new List<string> { "e" }, Codewars.kyu4.FreqWords.Top3("  , e   .. "));
            Assert.Equal(new List<string> { }, Codewars.kyu4.FreqWords.Top3("  ...  "));
            Assert.Equal(new List<string> { }, Codewars.kyu4.FreqWords.Top3("  '  "));
            Assert.Equal(new List<string> { }, Codewars.kyu4.FreqWords.Top3("  '''  "));
            Assert.Equal(new List<string> { "a", "of", "on" }, Codewars.kyu4.FreqWords.Top3(
                string.Join("\n", new string[]{"In a village of La Mancha, the name of which I have no desire to call to",
                  "mind, there lived not long since one of those gentlemen that keep a lance",
                  "in the lance-rack, an old buckler, a lean hack, and a greyhound for",
                  "coursing. An olla of rather more beef than mutton, a salad on most",
                  "nights, scraps on Saturdays, lentils on Fridays, and a pigeon or so extra",
                  "on Sundays, made away with three-quarters of his income." })));
        }
    }
}

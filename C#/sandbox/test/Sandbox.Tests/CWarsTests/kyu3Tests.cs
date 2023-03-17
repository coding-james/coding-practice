using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests
{
    public class kyu3
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

            public void RailFenceCipher_Encode(string expected, string input1, int input2)
            {
                Assert.Equal(expected, CWars.kyu3.Encode(input1, input2));
            }

            [Theory]
            [InlineData("WEAREDISCOVEREDFLEEATONCE", "WECRLTEERDSOEEFEAOCAIVDEN", 3)]
            [InlineData("Hello, World!", "Hoo!el,Wrdl l", 3)]
            [InlineData("Hello, World!", "H !e,Wdloollr", 4)]
            [InlineData("", "", 3)]
            [InlineData("ABC", "ABC", 3)]
            [InlineData("AB", "AB", 2)]

            public void RailFenceCipher_Decode(string expected, string input1, int input2)
            {
                Assert.Equal(expected, CWars.kyu3.Decode(input1, input2));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu6
{
    public class CreatePhoneNumber
    {
        // CODEWARS: Create Phone Number
        [Fact]
        public void CreatePhoneNum() => Assert.Equal("(123) 456-7890", Codewars.kyu6.CreatePhoneNumber.CreatePhoneNum(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }));
    }
}

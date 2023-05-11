using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Tests.CodewarsTests.kyu6
{
    public class MultipleOf3Or5
    {
        // CODEWARS: Mutliple of 3 or 5
        [Fact]
        public void MultiOf3or5() => Assert.Equal(23, Codewars.kyu6.MultipleOf3Or5.MultiOf3or5(10));
    }
}

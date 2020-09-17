using System;
using Xunit;

namespace Test
{
    public class UnitTest1
    {
        [Fact(DisplayName ="Debe ser true")]
        
        public void Test1()
        {
            bool isTrue = true;

            Assert.True(isTrue);
        }
    }
}

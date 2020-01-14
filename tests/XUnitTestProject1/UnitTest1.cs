using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void SuccessTest()
        {
            var c = new xUnitTest.Class1();
            c.Success();
        }

        [Fact]
        public void ThrowTest()
        {
            var c = new xUnitTest.Class1();
            Assert.Throws<Exception>(() => c.Throw());
        }

        [Fact]
        public void BoolSuccessTest()
        {
            var c = new xUnitTest.Class1();
            Assert.True(c.BoolExec(true));
        }

        [Fact]
        public void BoolFailTest()
        {
            var c = new xUnitTest.Class1();
            Assert.False(c.BoolExec(true));
        }
    }
}

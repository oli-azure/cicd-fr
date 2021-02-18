using System;
using Xunit;

namespace MyWebApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test_true_is_true()
        {
            Assert.True(true);
        }

        [Fact]
        public void Test_false_is_false()
        {
            Assert.False(false);
        }

        [Fact]
        public void Test_olivier_is_lit()
        {
            var olivier = "🔥🔥🔥";
            Assert.Equal("🔥🔥🔥", olivier);
        }
    }
}

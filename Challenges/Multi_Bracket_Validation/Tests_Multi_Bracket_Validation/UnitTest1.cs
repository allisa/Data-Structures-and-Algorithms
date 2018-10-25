using System;
using Xunit;
using Multi_Bracket_Validation;

namespace Tests_Multi_Bracket_Validation
{
    public class UnitTest1
    {
        /// <summary>
        /// Tests that balanced string retruns true
        /// </summary>
        [Fact]
        public void TestBalancedString()
        {
            string test1 = "(Hello World!)";

            Assert.True(Program.MultiBracketValidation(test1));
        }

        /// <summary>
        /// Test that empty string returns true
        /// </summary>
        [Fact]
        public void TestEmptyString()
        {
            string test5 = "";

            Assert.True(Program.MultiBracketValidation(test5));
        }

        /// <summary>
        /// Test that an unbalanced string returns false
        /// </summary>
        [Fact]
        public void TestUnbalancedString()
        {
            string test3 = "(({}{})";

            Assert.False(Program.MultiBracketValidation(test3));
        }
    }
}

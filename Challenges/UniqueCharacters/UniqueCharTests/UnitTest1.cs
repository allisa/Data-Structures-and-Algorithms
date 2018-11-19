using System;
using Xunit;
using UniqueCharacters;

namespace UniqueCharTests
{
    public class UnitTest1
    {
        /// <summary>
        /// test to look for unique characters in strings
        /// </summary>
        /// <param name="testString"></param>
        /// <param name="expected"></param>
        [Theory]
        [InlineData("Hello World", false)]
        [InlineData("asdfg hjkl zxcvb nmqwer", true)]
        [InlineData("Wizard world", false)]
        public void TestUniqueCharacters(string testString, bool expected)
        {
            Assert.Equal(expected, Program.UniqueChar(testString));
        }
    }
}

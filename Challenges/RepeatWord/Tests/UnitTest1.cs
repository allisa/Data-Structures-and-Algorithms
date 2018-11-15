using RepeatWord;
using System;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        /// <summary>
        /// test to find repeated word
        /// </summary>
        [Fact]
        public void CanFindRepeatedWord()
        {
            string testString = "Once upon a time, there was a brave princess who...";
            Program.RepeatedWord(testString);

            Assert.Equal("a", Program.RepeatedWord(testString));
        }

        /// <summary>
        /// test to find no repeated word
        /// </summary>
        [Fact]
        public void CanFindNoRepeatedWord()
        {
            string testString = "Once upon a time, there was tv...";
            Program.RepeatedWord(testString);

            Assert.Null(Program.RepeatedWord(testString));
        }

        //can't think of third test

    }
}

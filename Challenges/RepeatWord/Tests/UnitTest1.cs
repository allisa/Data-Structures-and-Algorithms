using RepeatWord;
using System;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        /// <summary>
        /// testing different senctences to find first repeating word
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="sentence"></param>
        [Theory]
        [InlineData("a", "Once upon a time, there was a brave princess who...")]
        [InlineData("summer", "It was a queer, sultry summer the summer they electrocuted the Rosenbergs")]
        public void Tests(string expected, string sentence)
        {
            Assert.Equal(expected, Program.RepeatedWord(sentence));
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
    }
}

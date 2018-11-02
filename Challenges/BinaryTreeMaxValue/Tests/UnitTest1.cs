using System;
using Trees.Classes;
using Xunit;
using BinaryTreeMaxValue;

namespace Tests
{
    public class UnitTest1
    {
        /// <summary>
        /// test to prove the find max value method will return a value
        /// </summary>
        /// <param name="value"></param>
        [Theory]
        [InlineData(2)]
        [InlineData(-22)]
        [InlineData(0)]
        [InlineData(44)]
        [InlineData(16)]
        public void TestForDifferentValues(int value)
        {
            BinaryTree tree = new BinaryTree(new Node(value));
            tree.Root.LeftChild = new Node(Int32.MinValue);

            Assert.Equal(value, Program.FindMaxValue(tree.Root));
        }
    }
}

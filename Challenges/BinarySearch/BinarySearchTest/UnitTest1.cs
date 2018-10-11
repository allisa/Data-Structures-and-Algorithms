using System;
using Xunit;
using BinarySearch;

namespace BinarySearchTest
{
    public class UnitTest1
    {
        //test for correct answer in an array
        [Fact]
        public void TargetInArray()
        {
            int[] testArray = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Assert.Equal(4, Program.BinarySearchMethod(testArray, 5));
        }

        //test for target not in array
        [Fact]
        public void TargetNotInArray()
        {
            int[] testArray = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Assert.Equal(-1, Program.BinarySearchMethod(testArray, 10));
        }

        //test for empty array
        [Fact]
        public void EmptyArray()
        {
            int[] testArray = {};
            Assert.Equal(-1, Program.BinarySearchMethod(testArray, 2));
        }
    }
}

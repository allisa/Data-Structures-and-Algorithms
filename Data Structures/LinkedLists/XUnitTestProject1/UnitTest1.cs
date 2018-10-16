using System;
using Xunit;
using LinkedLists.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        
        public void CanAddToBeginningOfList()
        {
            Node testNode = new Node(2);
            Node testNode2 = new Node(44);
            LList testList = new LList(testNode);
            testList.Add(testNode2);

            Assert.Equal(44, testList.Head.Value);

        }

        [Theory]

        [InlineData(44)]
        [InlineData(true)]
        [InlineData("pooka")]

        public void CanAddToBeginning(object testValue)
        {
            Node testNode = new Node("dog");
            Node testNode2 = new Node(false);
            Node testNode3 = new Node(testValue);
            LList testList = new LList(testNode);
            testList.Add(testNode2);
            testList.Add(testNode3);

            Assert.Equal(testValue, testList.Head.Value);

        }

        [Theory]

        [InlineData(44)]
        [InlineData(true)]
        [InlineData("pooka")]

        public void CanAddBeforeGivenNode(object testValue)
        {
            Node testNode = new Node("dog");
            Node testNode2 = new Node(false);
            Node testNode3 = new Node(testValue);
            LList testList = new LList(testNode);
            testList.Add(testNode2);
            testList.AddBefore(testNode3, testNode2);

            Assert.Equal(testValue, testList.Head.Value);
        }

        [Theory]

        [InlineData(44)]
        [InlineData(true)]
        [InlineData("pooka")]

        public void CanAddAfterGivenNode(object testValue)
        {
            Node testNode = new Node("dog");
            Node testNode2 = new Node(false);
            Node testNode3 = new Node(testValue);
            LList testList = new LList(testNode);
            testList.Add(testNode2);
            testList.AddAfter(testNode3, testNode2);

            Assert.Equal(testValue, testList.Head.Next.Value);
        }

    }
}


using System;
using Xunit;
using LinkedLists.Classes;
using LL_Kth_From_End;

namespace XUnitTestProject1
{
    /// <summary>
    /// Test to find the kth from the end of the linked list
    /// </summary>
    public class UnitTest1
    {
        [Theory]

        [InlineData(4, "dog")]
        [InlineData(2, 4)]
        [InlineData(5, "Exception, out of bounds")]

        public void CanFindkthNode(int k, object value)
        {
            Node testNode = new Node(7);
            Node testNode1 = new Node("dog");
            Node testNode2 = new Node(4);
            Node testNode3 = new Node(33);
            Node testNode4 = new Node("button");
            
            LList testList = new LList(testNode);
            testList.Add(testNode1);
            testList.Append(testNode2);
            testList.Append(testNode3);
            testList.Append(testNode4);

            Assert.Equal(value, Program.FindKthElement(testList, k));
        }
    }
}

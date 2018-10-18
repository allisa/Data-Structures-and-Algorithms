using System;
using Xunit;
using LL_Merge;
using LinkedLists.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {

        /// <summary>
        /// Test to prove first node in linked list one is firt node in merged list
        /// </summary>
        [Fact]
        public void TestingThatFirstNodeInFirstListIsFirstNodeInMergedList()
        {
            LList listOne = new LList(new Node(1));
            LList listTwo = new LList(new Node(2));

            listOne.Append(new Node(3));
            listTwo.Append(new Node(4));
            LList result = Program.Merge(listOne, listTwo);
            Assert.Equal(1, result.Head.Value);
        }

        /// <summary>
        /// Test to prove first node in linked list two is second node in merged list
        /// </summary>
        [Fact]
        public void TestingSecondListHeadNodeEaqualsSecondNodeInMergedList()
        {
            LList listOne = new LList(new Node(1));
            LList listTwo = new LList(new Node(2));

            listOne.Append(new Node(3));
            listTwo.Append(new Node(4));
            LList result = Program.Merge(listOne, listTwo);

            Assert.Equal(2, result.Head.Next.Value); ;
        }

    }
}

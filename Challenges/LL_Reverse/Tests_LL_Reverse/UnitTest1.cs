using System;
using Xunit;
using LinkedLists.Classes;
using LL_Reverse;

namespace Tests_LL_Reverse
{
    public class UnitTest1
    {

        /// <summary>
        /// Test to prove the linked list is reversed
        /// </summary>
        [Fact]
        public void CanReverseLList()
        {
            LList list = new LList(new Node(1));

            list.Append(new Node(2));
            list.Append(new Node(3));

            Assert.Equal(list, Program.Reverse(list));
        }

        /// <summary>
        /// Test to prove the first node in the reversed list is the last node in original link list
        /// </summary>
        [Fact]
        public void FirstNodeIsOriginalLastNode()
        {
            LList list = new LList(new Node(1));

            list.Append(new Node(2));
            list.Append(new Node(3));
            list.Append(new Node(4));
            list.Append(new Node(5));

            LList reversedList = Program.Reverse(list);

            Assert.Equal(5, reversedList.Head.Value);
        }

        /// <summary>
        /// Test to check that the second node was reversed and that is wasn't just the first and last node switched
        /// </summary>
        [Fact]
        public void CheckingThatSecondNodeIsReversed()
        {
            LList list = new LList(new Node(1));

            list.Append(new Node(2));
            list.Append(new Node(3));
            list.Append(new Node(4));
            list.Append(new Node(5));

            LList reversedList = Program.Reverse(list);

            Assert.Equal(4, reversedList.Head.Next.Value);
        }

    }
}

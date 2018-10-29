using System;
using System.Collections.Generic;
using Trees.Classes;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        /// <summary>
        /// Testing for root
        /// </summary>
        [Fact]
        public void TestForRoot()
        {
            Node node1 = new Node(30);
            Node node2 = new Node(35);
            Node node3 = new Node(40);
            Node node4 = new Node(45);

            BinaryTree bt1 = new BinaryTree(node1);
            bt1.Root.LeftChild = node2;
            bt1.Root.LeftChild.LeftChild = node3;
            bt1.Root.RightChild = node4;

            Assert.Equal(node1, bt1.Root);
        }

        /// <summary>
        /// Test for pre-order traversal
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <param name="value3"></param>
        [Theory]
        [InlineData(30, 35, 40)]
        [InlineData(45, 50, 55)]
        [InlineData(60, 65, 70)]
        public void TestForPreOrder(int value1, int value2, int value3)
        {
         
            List<int> expectedValues = new List<int> { value1, value2, value3 };
           
            BinaryTree bt1 = new BinaryTree(new Node(value1));
            bt1.Root.LeftChild = new Node(value2);
            bt1.Root.RightChild = new Node(value3);
            bt1.PreOrder(bt1.Root);
            bt1.values.Clear();

            Assert.Equal(expectedValues, bt1.PreOrder(bt1.Root));
        }

        /// <summary>
        /// Test for in-order traversal
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <param name="value3"></param>
        [Theory]
        [InlineData(30, 35, 40)]
        [InlineData(45, 50, 55)]
        [InlineData(60, 65, 70)]
        public void TestForInOrder(int value1, int value2, int value3)
        {

            List<int> expectedValues = new List<int> { value2, value1, value3 };

            BinaryTree bt1 = new BinaryTree(new Node(value1));
            bt1.Root.LeftChild = new Node(value2);
            bt1.Root.RightChild = new Node(value3);
            bt1.InOrder(bt1.Root);
            bt1.values.Clear();

            Assert.Equal(expectedValues, bt1.InOrder(bt1.Root));
        }

        /// <summary>
        /// Test for post-order traversal
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <param name="value3"></param>
        [Theory]
        [InlineData(30, 35, 40)]
        [InlineData(45, 50, 55)]
        [InlineData(60, 65, 70)]
        public void TestForPostOrder(int value1, int value2, int value3)
        {

            List<int> expectedValues = new List<int> { value2, value3, value1 };

            BinaryTree bt1 = new BinaryTree(new Node(value1));
            bt1.Root.LeftChild = new Node(value2);
            bt1.Root.RightChild = new Node(value3);
            bt1.PostOrder(bt1.Root);
            bt1.values.Clear();

            Assert.Equal(expectedValues, bt1.PostOrder(bt1.Root));
        }


    }
}

using System;
using Trees.Classes;
using Xunit;
using TreeIntersection;

namespace TreeIntersectionTests
{
    public class UnitTest1
    {
        /// <summary>
        /// test to find a match
        /// </summary>
        [Fact]
        public void CanFindOneMatch()
        {
            BinaryTree bt1 = new BinaryTree(new Node(2));
            bt1.Root.LeftChild = new Node(4);
            bt1.Root.LeftChild.LeftChild = new Node(6);
            bt1.Root.RightChild = new Node(8);
            bt1.Root.RightChild.LeftChild = new Node(10);

            BinaryTree bt2 = new BinaryTree(new Node(12));
            bt2.Root.LeftChild = new Node(14);
            bt2.Root.LeftChild.RightChild = new Node(4);
            bt2.Root.RightChild = new Node(16);
            bt2.Root.RightChild.LeftChild = new Node(18);

            Assert.Contains("4", Program.IntersectedTrees(bt1, bt2));
        }

        /// <summary>
        /// test to find more than one match
        /// </summary>
        [Fact]
        public void CanFindMoreThanOneMatch()
        {
            BinaryTree bt1 = new BinaryTree(new Node(2));
            bt1.Root.LeftChild = new Node(4);
            bt1.Root.LeftChild.LeftChild = new Node(6);
            bt1.Root.RightChild = new Node(8);
            bt1.Root.RightChild.LeftChild = new Node(10);

            BinaryTree bt2 = new BinaryTree(new Node(12));
            bt2.Root.LeftChild = new Node(14);
            bt2.Root.LeftChild.RightChild = new Node(4);
            bt2.Root.RightChild = new Node(8);
            bt2.Root.RightChild.LeftChild = new Node(18);

            Assert.Contains("4", Program.IntersectedTrees(bt1, bt2));
            Assert.Contains("8", Program.IntersectedTrees(bt1, bt2));
        }

        /// <summary>
        /// test to find no match
        /// </summary>
        [Fact]
        public void CanFindNoMatch()
        {
            BinaryTree bt1 = new BinaryTree(new Node(2));
            bt1.Root.LeftChild = new Node(4);
            bt1.Root.LeftChild.LeftChild = new Node(6);
            bt1.Root.RightChild = new Node(8);
            bt1.Root.RightChild.LeftChild = new Node(10);

            BinaryTree bt2 = new BinaryTree(new Node(12));
            bt2.Root.LeftChild = new Node(14);
            bt2.Root.LeftChild.RightChild = new Node(20);
            bt2.Root.RightChild = new Node(16);
            bt2.Root.RightChild.LeftChild = new Node(18);

            Assert.Empty(Program.IntersectedTrees(bt1, bt2));
        }
    }
}

using System;
using Trees.Classes;

namespace BinaryTreeMaxValue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            BinaryTree tree = new BinaryTree(new Node(2));
            tree.Root.LeftChild = new Node(22);
            tree.Root.RightChild = new Node(4);
            tree.Root.LeftChild.LeftChild = new Node(44);
            tree.Root.LeftChild.RightChild = new Node(6);
            tree.Root.RightChild.LeftChild = new Node(66);
            tree.Root.RightChild.RightChild = new Node(24);

            int result = FindMaxValue(tree.Root);
            Console.WriteLine(result);
        }


        /// <summary>
        /// Method to recursively find the max value in a binary tree
        /// </summary>
        /// <param name="root"></param>
        /// <returns>max value</returns>
        public static int FindMaxValue(Node root)
        {
            int tempMax = root.Value;
            int leftMax = (root.LeftChild != null) ? FindMaxValue(root.LeftChild) : root.Value;
            int rightMax = (root.RightChild != null) ? FindMaxValue(root.RightChild) : root.Value;

            if (leftMax > tempMax)
            {
                tempMax = leftMax;
            }
            if (rightMax > tempMax)
            {
                tempMax = rightMax;
            }
            return tempMax;
        }
    }
}

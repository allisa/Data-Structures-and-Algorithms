using System;
using System.Collections.Generic;
using Trees.Classes;

namespace Trees
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            TreeTest();

        }

        public static void TreeTest()
        {
            Node node1 = new Node(30);
            Node node2 = new Node(35);
            Node node3 = new Node(40);
            Node node4 = new Node(45);
            Node node5 = new Node(50);
            Node node6 = new Node(55);
            Node node7 = new Node(60);

            BinaryTree bt1 = new BinaryTree(node1);
            bt1.Root.LeftChild = node2;
            bt1.Root.LeftChild.LeftChild = node3;
            bt1.Root.LeftChild.RightChild = node4;
            bt1.Root.RightChild = node5;
            bt1.Root.RightChild.LeftChild = node6;
            bt1.Root.RightChild.RightChild = node7;

    

            List<int> preOrder = bt1.PreOrder(bt1.Root);

            Console.WriteLine("Pre-order traversal:");

            foreach (int item in preOrder)
            {
                Console.WriteLine($"{item}");
            }

            bt1.values.Clear();

            List<int> inOrder = bt1.InOrder(bt1.Root);

            Console.WriteLine("In-order traversal:");

            foreach (int item in inOrder)
            {
                Console.WriteLine($"{item}");
            }

            bt1.values.Clear();

            List<int> postOrder = bt1.PostOrder(bt1.Root);

            Console.WriteLine("Post-order traversal:");

            foreach (int item in postOrder)
            {
                Console.WriteLine($"{item}");
            }

            bt1.values.Clear();

            BinarySearchTree bts = new BinarySearchTree(node1);

            Console.WriteLine("Add node2 (35) to binary search tree:");

            bts.AddNode(node1, node2);
            Console.WriteLine($"Tree values: {bts.Root.Value}, {bts.Root.LeftChild.Value}");
        }

    }
}

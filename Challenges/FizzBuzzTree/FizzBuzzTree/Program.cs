using System;
using Trees.Classes;

namespace FizzBuzzTree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node node1 = new Node(30);
            Node node2 = new Node(4);
            Node node3 = new Node(15);
            Node node4 = new Node(5);
            Node node5 = new Node(3);
            Node node6 = new Node(55);
            Node node7 = new Node(7);

            BinaryTree bt1 = new BinaryTree(node1);
            node1.LeftChild = node2;
            node1.LeftChild.LeftChild = node3;
            node1.LeftChild.RightChild = node4;
            node1.RightChild = node5;
            node1.RightChild.LeftChild = node6;
            node1.RightChild.RightChild = node7;

            Console.WriteLine("Fizz Buzz with Binary Tree");

            FizzBuzzTrees(bt1);
            
        }

        public static void FizzBuzzTrees(BinaryTree tree)
        {
            TraverseTree(tree.Root);
        }

        public static void TraverseTree(Node root)
        {
                if (root.Value % 15 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (root.Value % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (root.Value % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine($"{root.Value.ToString()}");
                if (root.LeftChild != null)
                    TraverseTree(root.LeftChild);
                if (root.RightChild != null)
                    TraverseTree(root.RightChild);
        }
    }
}

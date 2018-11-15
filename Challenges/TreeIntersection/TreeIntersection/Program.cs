using HashTables.Classes;
using System;
using System.Collections.Generic;
using Trees.Classes;

namespace TreeIntersection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node node1 = new Node(2);

            BinaryTree bt1 = new BinaryTree(node1);
            bt1.Root.LeftChild = new Node(4);
            bt1.Root.LeftChild.LeftChild = new Node(6);
            bt1.Root.RightChild = new Node(8);
            bt1.Root.RightChild.LeftChild = new Node(10);

            BinaryTree bt2 = new BinaryTree(new Node(12));
            bt2.Root.LeftChild = new Node(14);
            bt2.Root.LeftChild.RightChild = new Node(4);
            bt2.Root.RightChild = new Node(8);
            bt2.Root.RightChild.LeftChild = new Node(18);

            List<string> commonValuesInTrees = IntersectedTrees(bt1, bt2);

            Console.WriteLine("Common values are:");

            foreach(string item in commonValuesInTrees)
            {
                Console.WriteLine(item);
            }


        }

        public static List<string> IntersectedTrees(BinaryTree binaryTree, BinaryTree binaryTree2)
        {
            List<string> commonValues = new List<string>();
            HashTable hashTable = new HashTable();

            List<int> tree1 = binaryTree.PreOrder(binaryTree.Root);
            List<int> tree2 = binaryTree2.PreOrder(binaryTree2.Root);

            foreach(int value in tree1)
            {
                Node node = new Node(value);
                hashTable.Add(node.Value.ToString(), null);
            }

            foreach (int value in tree2)
            {
                if(hashTable.Contains(value.ToString()))
                {
                    commonValues.Add(value.ToString());
                }
            }
            return commonValues;
        }
    }
}

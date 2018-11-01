using System;
using System.Collections;
using System.Collections.Generic;
using Trees.Classes;

namespace BreadthFirstTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            BinaryTree tree = new BinaryTree(new Node(2));
            tree.Root.LeftChild = new Node(22);
            tree.Root.RightChild = new Node(4);
            tree.Root.LeftChild.LeftChild = new Node(44);
            tree.Root.LeftChild.RightChild = new Node(6);
            tree.Root.RightChild.LeftChild = new Node(66);
            tree.Root.RightChild.RightChild = new Node(24);

            BreadthFirst(tree);
        }

        public static void BreadthFirst(BinaryTree tree)
        {
            Queue<Node> queue = new Queue<Node>();
            if (tree.Root != null)
            {
                queue.Enqueue(tree.Root);
            }
            else
                return;


            while (queue.Count > 0)
            {
            Node current = queue.Peek();
            Console.WriteLine(current.Value);
                if (current.LeftChild != null)
                {
                    queue.Enqueue(current.LeftChild);
                }
                if (current.RightChild != null)
                {
                    queue.Enqueue(current.RightChild);
                }
            queue.Dequeue();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }

        public BinarySearchTree(Node root)
        {
            Root = root;
        }

        /// <summary>
        /// Adds node to bianry search tree. Modified code from a stackoverflow solution
        /// </summary>
        /// <param name="root"></param>
        /// <param name="newNode"></param>
        public void AddNode(Node root, Node newNode)
        {
            if (root == null)
            {
                root = newNode;
            }
            if (root.Value == newNode.Value)
            {
                return;
            }
            else if (root.Value > newNode.Value)
            {
                if (root.LeftChild == null)
                {
                    root.LeftChild = newNode;
                }
                else
                {
                    AddNode(root.LeftChild, newNode);
                }
            }
            else if (root.Value < newNode.Value)
            {
                if (root.RightChild == null)
                {
                    root.RightChild = newNode;
                }
                else
                {
                    AddNode(root.RightChild, newNode);
                }
            }
        }

        /// <summary>
        /// Method to search bianry tree for value. Compares value to the root and searches right or left depending on if the value is less than or greater than
        /// </summary>
        /// <param name="root"></param>
        /// <param name="value"></param>
        /// <returns>node value</returns>
        public Node Search(Node root, int value)
        {
            while (root.Value != value)
            { 
                if (root.Value == value)
                {
                    return root;
                }
                if (value < root.Value)
                {
                    root = root.LeftChild;
                }
                if (value > root.Value)
                {
                    root = root.RightChild;
                }
            }
            return root;
        }
    }
}

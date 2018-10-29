using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }
        public List<Node> nodes { get; set; }

        public BinaryTree(Node root)
        {
            Root = root;
        }

        /// <summary>
        /// Method to traverse a binary tree looking at root first, then left child, then right child
        /// </summary>
        /// <param name="root"></param>
        /// <returns>List of nodes</returns>
        public List<Node> PreOrder(Node root)
        {
            if (root.LeftChild != null)
            {
                PreOrder(root.LeftChild);
            }
            if (root.RightChild != null)
            {
                PreOrder(root.RightChild);
            }
            return nodes;
        }

        /// <summary>
        /// Method to traverse tree looking at left child first, root, and then right child
        /// </summary>
        /// <param name="root"></param>
        /// <returns>List of nodes</returns>
        public List<Node> InOrder(Node root)
        {
            if (root.LeftChild != null)
            {
                InOrder(root.LeftChild);
                nodes.Add(root);
            }
            if (root.RightChild != null)
            {
                InOrder(root.RightChild);
            }
            return nodes;
        }

        /// <summary>
        /// Method to traverse tree looking at the left child, right child, and then root
        /// </summary>
        /// <param name="root"></param>
        /// <returns>List of nodes</returns>
        public List<Node> PostOrder(Node root)
        {
            if (root.LeftChild != null)
            {
                PostOrder(root.LeftChild);
            }
            if (root.RightChild != null)
            {
                PostOrder(root.RightChild);
                nodes.Add(root);
            }
            return nodes;
        }
    }
}

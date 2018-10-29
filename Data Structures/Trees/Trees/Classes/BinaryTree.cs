using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }
        public List<int> values = new List<int>();

        public BinaryTree(Node root)
        {
            Root = root;
        }

        /// <summary>
        /// Method to traverse a binary tree looking at root first, then left child, then right child
        /// </summary>
        /// <param name="root"></param>
        /// <returns>List of nodes</returns>
        public List<int> PreOrder(Node root)
        {
            values.Add(root.Value);
            if (root.LeftChild != null)
            {
                PreOrder(root.LeftChild);
            }
            if (root.RightChild != null)
            {
                PreOrder(root.RightChild);
            }
            return values;
        }

        /// <summary>
        /// Method to traverse tree looking at left child first, root, and then right child
        /// </summary>
        /// <param name="root"></param>
        /// <returns>List of nodes</returns>
        public List<int> InOrder(Node root)
        {
            if (root != null)
            { 
                InOrder(root.LeftChild);
                values.Add(root.Value);
                InOrder(root.RightChild);
            }
            return values;
        }

        /// <summary>
        /// Method to traverse tree looking at the left child, right child, and then root
        /// </summary>
        /// <param name="root"></param>
        /// <returns>List of nodes</returns>
        public List<int> PostOrder(Node root)
        {
            if (root!= null)
            {
                PostOrder(root.LeftChild);
                PostOrder(root.RightChild);
                values.Add(root.Value);
            }
            return values;
        }
    }
}

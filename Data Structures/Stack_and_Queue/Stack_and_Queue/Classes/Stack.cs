using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_and_Queue.Classes
{
    public class Stack
    {
        public Node Top { get; set; }

        public Stack(Node node)
        {
            Top = node;
        }

        /// <summary>
        /// Method to peek at the top of the stack before attempting to pop otherwise a NullReferenceException is thrown
        /// </summary>
        /// <returns>Node</returns>
        public Node Peek()
        {
            try
            {
                return Top;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method to remove nodes from the stack
        /// </summary>
        /// <returns>Node</returns>
        public Node Pop()
        {
            Node temp = Peek();
            Top = Top.Next;
            temp.Next = null;
            return temp;
        }

        /// <summary>
        /// Method to push nodes into the stack
        /// </summary>
        /// <param name="node"></param>
        public void Push(Node node)
        {
            node.Next = Top;
            Top = node;
        }

    }
}

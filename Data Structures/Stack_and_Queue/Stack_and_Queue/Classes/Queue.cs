using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_and_Queue.Classes
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }

        public Queue(Node node)
        {
            Front = node;
            Rear = node;
        }

        /// <summary>
        /// Method to view the front node in the queue. We do this so we do not get a NullReferenceException if the queue is empty
        /// </summary>
        /// <returns></returns>
        public Node Peek()
        {
            return Front;
        }

        /// <summary>
        /// Method to add a node to a queue
        /// </summary>
        /// <param name="node"></param>
        public void Enqueue(Node node)
        {
            Rear.Next = node;
            Rear = node;
        }

        /// <summary>
        /// Method to remove a node from a queue
        /// </summary>
        /// <param name="node"></param>
        /// <returns>Node</returns>
        public Node Dequeue()
        {
            Node temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp;
        }

    }
}

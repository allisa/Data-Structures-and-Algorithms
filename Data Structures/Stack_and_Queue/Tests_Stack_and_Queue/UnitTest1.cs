using System;
using Xunit;
using Stack_and_Queue.Classes;

namespace Tests_Stack_and_Queue
{
    public class UnitTest1
    {
        /// <summary>
        /// test that node can be pushed on stack
        /// </summary>
        [Fact]
        public void CanPushNodeOnStack()
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);

            Stack stack = new Stack(null);
            stack.Push(node1);
            stack.Push(node2);
            stack.Push(node3);

            Assert.Equal(node3, stack.Peek());
        }

        /// <summary>
        /// test to see if node can be popped from a stack
        /// </summary>
        [Fact]
        public void CanPopNodeOffStack()
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);

            Stack stack = new Stack(null);
            stack.Push(node1);
            stack.Push(node2);
            stack.Push(node3);

            stack.Pop();

            Assert.Equal(node2, stack.Peek());
        }

        /// <summary>
        /// test to prove peeking at stack
        /// </summary>
        [Fact]
        public void CanPeekAtStack()
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);

            Stack stack = new Stack(null);
            stack.Push(node1);
            stack.Push(node2);
            stack.Push(node3);

            Assert.Equal(node3, stack.Peek());
        }

        /// <summary>
        /// test to prove nodes were added/enqueued to queue
        /// </summary>
        [Fact]
        public void CanAddToAQueue()
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);

            Queue queue = new Queue(node1);
            queue.Enqueue(node2);
            queue.Enqueue(node3);

            Assert.Equal(node3, queue.Rear);
        }

        /// <summary>
        /// test to prove node1 was removed/dequeued from queue
        /// </summary>
        [Fact]
        public void CanRemoveFromQueue()
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);

            Queue queue = new Queue(node1);
            queue.Enqueue(node2);
            queue.Enqueue(node3);

            queue.Dequeue();

            Assert.Equal(node2, queue.Front);
        }

        /// <summary>
        /// test to prove the queue can be peeked at
        /// </summary>
        [Fact]
        public void CanPeekAtQueue()
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);

            Queue queue = new Queue(node1);

            Assert.Equal(node1, queue.Peek());
        }
    }
}

using System;
using Xunit;
using QueueWithStacks.Classes;
using Stack_and_Queue.Classes;


namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestToRemoveFirstNodeAddedToQueue()
        {
            Stack stackOne = new Stack(null);
            Stack stackTwo = new Stack(null);

            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);

            QueueOfStacks queue = new QueueOfStacks(stackOne, stackTwo);

            queue.Enqueue(node1);
            queue.Enqueue(node2);
            queue.Enqueue(node3);

            Assert.Equal(node1.Value, queue.Dequeue().Value);
        }

        [Fact]
        public void LastNodeAddedIsNotFirstOut()
        {
            Stack stackOne = new Stack(null);
            Stack stackTwo = new Stack(null);

            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);

            QueueOfStacks queue = new QueueOfStacks(stackOne, stackTwo);

            queue.Enqueue(node1);
            queue.Enqueue(node2);
            queue.Enqueue(node3);

            Assert.NotEqual(node3.Value, queue.Dequeue().Value);
        }

        [Fact]
        public void TestToEnqueueDequeueEnqueue()
        {
            Stack stackOne = new Stack(null);
            Stack stackTwo = new Stack(null);

            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);

            QueueOfStacks queue = new QueueOfStacks(stackOne, stackTwo);

            queue.Enqueue(node1);
            queue.Enqueue(node2);
            queue.Enqueue(node3);

            queue.Dequeue();

            queue.Enqueue(node4);

            Assert.Equal(2, queue.Dequeue().Value);
        }

        [Fact]
        public void TestSingleNode()
        {
            Stack stackOne = new Stack(null);
            Stack stackTwo = new Stack(null);

            Node node1 = new Node(1);
            

            QueueOfStacks queue = new QueueOfStacks(stackOne, stackTwo);

            queue.Enqueue(node1);

            Assert.Equal(node1.Value, queue.Dequeue().Value);
        }

        [Fact]
        public void TestMultipleeDequeues()
        {
            Stack stackOne = new Stack(null);
            Stack stackTwo = new Stack(null);

            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);

            QueueOfStacks queue = new QueueOfStacks(stackOne, stackTwo);

            queue.Enqueue(node1);
            queue.Enqueue(node2);
            queue.Enqueue(node3);

            queue.Dequeue();
            queue.Dequeue();

            Assert.Equal(3, queue.Dequeue().Value);
        }


        [Fact]
        public void TestMultipleeEnqueues()
        {
            Stack stackOne = new Stack(null);
            Stack stackTwo = new Stack(null);

            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);

            QueueOfStacks queue = new QueueOfStacks(stackOne, stackTwo);

            queue.Enqueue(node1);
            queue.Enqueue(node2);
            queue.Enqueue(node3);

            queue.Dequeue();
            queue.Dequeue();

            queue.Enqueue(node4);
            queue.Enqueue(node5);


            Assert.Equal(3, queue.Dequeue().Value);
        }



    }
}

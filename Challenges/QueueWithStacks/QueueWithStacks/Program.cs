using System;
using Stack_and_Queue.Classes;
using QueueWithStacks.Classes;

namespace QueueWithStacks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Stack stackOne = new Stack(null);
            Stack stackTwo = new Stack(null);

            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);

            QueueOfStacks queue = new QueueOfStacks(stackOne, stackTwo);

            queue.Enqueue(node1);
            queue.Enqueue(node2);
            queue.Enqueue(node3);

            Console.WriteLine($"Item dequeued: {queue.Dequeue().Value}");
        }
    }
}

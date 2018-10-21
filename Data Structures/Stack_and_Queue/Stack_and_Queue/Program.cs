using System;
using Stack_and_Queue.Classes;

namespace Stack_and_Queue
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //creating instances of class Node
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);
            Node node6 = new Node(6);

            //Adding nodes to queue
            Queue queue = new Queue(node1);
            queue.Enqueue(node2);
            queue.Enqueue(node3);
            queue.Enqueue(node4);
            queue.Enqueue(node5);
            queue.Enqueue(node6);
            
            Console.WriteLine("Place in the queue: ");
            for (int i = 0; i < 6; i++)
            {
                //peeking at queue before removing
                Console.WriteLine($"Peek #{i}: ");
                Console.WriteLine($"{queue.Peek().Value}");

                //removing nodes from queue
                Console.WriteLine("Remove node: ");
                Node removeNode = queue.Dequeue();
                Console.WriteLine(removeNode.Value);
            }

            Console.WriteLine("****Stack****");
            Stack stack = new Stack(null);

            stack.Push(node6);
            stack.Push(node5);
            stack.Push(node4);
            stack.Push(node3);
            stack.Push(node2);
            stack.Push(node1);


            while (stack.Peek() != null)
            {
                Console.WriteLine(stack.Peek().Value);
                stack.Pop();
            }
        }
    }
}

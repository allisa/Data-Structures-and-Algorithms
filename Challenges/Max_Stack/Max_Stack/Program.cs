using System;
using Stack_and_Queue.Classes;

namespace Max_Stack
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);
            Node node6 = new Node(6);


            Stack testStack = new Stack(node1);
            testStack.Push(node2);
            testStack.Push(node3);
            testStack.Push(node4);
            testStack.Push(node5);
            testStack.Push(node6);

            GetMax(testStack);
        }

        public static int GetMax(Stack stack)
        {
            Stack stack2 = new Stack(null);
            int temp = 0;

            while(stack != null)
            {
                if (stack.Peek().Value  > temp)
                {
                    temp = Convert.ToUInt16(stack.Peek().Value);
                }
                stack2.Push(stack.Pop());
            }
            return temp;
        }
    }
}

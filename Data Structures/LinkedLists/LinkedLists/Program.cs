using System;
using LinkedLists.Classes;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Hello World!");

                Node node1 = new Node(7);
                Node node2 = new Node(40);
                Node node3 = new Node("dog");
                Node node4 = new Node(33);
                Node node5 = new Node("button");

            LList list = new LList(node1);
                list.Append(node2);

                list.Print();
        }
    }
}

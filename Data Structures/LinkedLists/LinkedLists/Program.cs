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

                LList list = new LList(node1);
                list.Append(node2);

                list.Print();
        }
    }
}

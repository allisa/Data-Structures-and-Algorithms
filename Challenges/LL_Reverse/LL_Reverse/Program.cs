using System;
using LinkedLists.Classes;

namespace LL_Reverse
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LList list = new LList(new Node(1));

            list.Append(new Node(2));
            list.Append(new Node(3));
            list.Append(new Node(4));
            list.Append(new Node(5));
            list.Append(new Node(6));

            Console.WriteLine("List before reversing");
            list.Print();

            Console.WriteLine("List after reversing");
            Reverse(list);
            list.Print();
        }

        /// <summary>
        /// Method to reverse a linked list
        /// </summary>
        /// <param name="list"></param>
        /// <returns>LList</returns>
        public static LList Reverse(LList list)
        {
            Node prevNode = null;
            Node nextNode = null;
            Node currentNode = list.Head;

            list.Current = list.Head;
            while (currentNode != null)
            {
                nextNode = currentNode.Next;
                currentNode.Next = prevNode;
                prevNode = currentNode;
                currentNode = nextNode;
            }
            list.Head = prevNode;
            return list;
        }
    }
}

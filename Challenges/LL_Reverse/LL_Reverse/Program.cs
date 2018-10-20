using System;
using LinkedLists.Classes;

namespace LL_Reverse
{
    class Program
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

        public static void Reverse(LList list)
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
        }

        //public static void Reverse(LList list)
        //{
        //    //Create pointers to track position
        //    Node current = list.Head, prev = null, next = null;

        //    list.Current = list.Head;
        //    while (list.Current != null)
        //    {
        //        //Get next link
        //        next = list.Current.Next;

        //        //Reverse current node's next ptr
        //        list.Current.Next = prev;

        //        //Advance pointers
        //        prev = list.Current;
        //        list.Current = list.Current.Next;
        //    }
        //    list.Head = prev;
        //}

    }
}

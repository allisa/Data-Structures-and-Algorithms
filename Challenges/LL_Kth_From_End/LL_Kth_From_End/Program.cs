using System;
using LinkedLists.Classes;

namespace LL_Kth_From_End
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node testNode = new Node(7);
            Node testNode1 = new Node("dog");
            Node testNode2 = new Node(4);
            Node testNode3 = new Node(33);
            Node testNode4 = new Node("button");

            LList testList = new LList(testNode);
            testList.Add(testNode1);
            testList.Append(testNode2);
            testList.Append(testNode3);
            testList.Append(testNode4);

            testList.Print();

        }

        /// <summary>
        /// Method to find the kth from the end of a linked list
        /// </summary>
        /// <param name="list"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static object FindKthElement(LList list, int k)
        {
            Node Current = list.Current;
            Node Head = list.Head;

            Current = Head;
            int length = 0;

            while (Current != null)
            {
                length++;
                Current = Current.Next;
            }
            if (k > length - 1)
            {
                return "Exception, out of bounds";
            }
            Current = Head;

            for (int i = 0; i < length - k - 1; i++)
            {
                Current = Current.Next;
            }
            return Current.Value;
        }

    }
}

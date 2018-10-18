using System;
using LinkedLists.Classes;

namespace LL_Merge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LList listOne = new LList(new Node(1));
            LList listTwo = new LList(new Node(2));

            listOne.Append(new Node(3));
            listTwo.Append(new Node(4));
            listOne.Append(new Node(5));
            listTwo.Append(new Node(6));
            listTwo.Append(new Node(7));

            listOne.Print();
            listTwo.Print();

            LList mergedList = Merge(listOne, listTwo);

            mergedList.Print();

        }


        public static LList Merge(LList one, LList two)
        {
            Node dummListStart = new Node(1);
            Node tail = new Node(2);

            one.Current = one.Head;
            two.Current = two.Head;

            while(true)
            {
                if(one.Current == null)
                {
                    tail.Next = two.Current;
                    break;
                }
                else if (two.Current == null)
                {
                    tail.Next = one.Current;
                    break;
                }
                else
                {
                    tail = one.Current;
                    tail.Next = one.Current.Next;
                    one.Current = one.Current.Next;
                    tail = two.Current;
                    tail.Next = two.Current.Next;
                    two.Current = two.Current.Next;
                }
            }
            LList mergedList = new LList(dummListStart.Next);
            return mergedList;
        }
    }
}

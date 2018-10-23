using System;
using System.Collections.Generic;
using System.Text;
using Stack_and_Queue.Classes;

namespace QueueWithStacks.Classes
{
    public class QueueOfStacks
    {
        Stack stack1 = new Stack(null);
        Stack stack2 = new Stack(null);

        /// <summary>
        /// Constructor for queue of stacks
        /// </summary>
        /// <param name="stackOne"></param>
        /// <param name="stackTwo"></param>
        public QueueOfStacks(Stack stackOne, Stack stackTwo)
        {
            stack1 = stackOne;
            stack2 = stackTwo;
        }

        /// <summary>
        /// enqueue to push node into stack one
        /// </summary>
        /// <param name="item"></param>
        public void Enqueue(Node item)
        {
            stack1.Push(item);
        }

        /// <summary>
        /// dequeue to pop items from first stack, push into second stack, and then pop off second stack.
        /// </summary>
        /// <returns>item popped off second stack</returns>
        public Node Dequeue()
        {
            Node popTemp = null;

            while (stack1.Top != null )
            {
                stack2.Push(stack1.Pop());
            }

            popTemp = stack2.Pop();

            while (stack2.Top != null)
            {
                stack1.Push(stack2.Pop());
            }
            return popTemp;
        }
    }
}

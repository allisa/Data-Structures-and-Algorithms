# Stacks and Queues

# Data Structure:
## Stack
A stack is a data structure representing a collection of objects. Stacks follow the concept LIFO, which means the last item in the stack will be the first removed from the stack.

## Queue
A queue is also a collection class where items are added to the queue on one end and removed from the other. Queues follow the concept FIFO, which means the first item added to the queue is the first item removed from the queue.

# Implementation

## Stack
In this implementation we used the Peek, Pop, and Pop operations for the stack. Peek is used to view the top node of the stack and is good practice to avoid getting a NullReferenceException if the stack is empty. Push is used to insert nodes to at the top of the stack. Pop is used to remove the item at the top of the stack.

## Queue
In this implementation we used the Enqueue, Dequeue, Front, Rear, and Peek operations. Peek has a similar purpose as it does in stack, where you view the front item in the queue to avoid reference exceptions before the dequeue operation. Enqueue adds an item to the rear of the queue. Dequeue removes an item from the front of the queue.

# Examples
Stacks and queues are helpful to temporaily store data until it is no longer needed. 

I think of a stack in terms of checking out library books. You take a stack of books to the counter where the top book is removed and scanned. You can't take and scan a book from the middle because you can't reach it in the stack.

I think of a queue as a food truck line. Your order is taken and then stored in a queue for preparation. Once your order has been made and handed off to you, the data is no longer needed and removed from the queue.

# Visual

![StackandQueueVisual](https://github.com/allisa/Data-Structures-and-Algorithms/blob/stack_and_queue/assets/stack_and_queue_visual.png)

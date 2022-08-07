using System;

namespace QueueImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // QueueWithArray queue = new QueueWithArray();
            QueueWithLinkedList queue = new QueueWithLinkedList();
            queue.Dequeue();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Print();

            queue.Dequeue();

            queue.Print();
            queue.Enqueue(6);
            queue.Print();
            queue.Dequeue();
            queue.Print();

            queue.Enqueue(7);
            queue.Print();


        }
    }
}

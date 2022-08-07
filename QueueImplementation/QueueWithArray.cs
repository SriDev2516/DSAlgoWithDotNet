using System;
using System.Collections.Generic;
using System.Text;

namespace QueueImplementation
{
    public class QueueWithArray
    {
        private const int SIZE = 3;
        private int[] array = new int[SIZE];

        private int front =0;
        private int rear =0;

        public void Enqueue(int data)
        {
            if(rear == SIZE)
            {
                Console.WriteLine("The queue is full");
                return;
            }
            if(rear < SIZE)
            {
                array[rear] = data;
                rear++;
            }

        }

        private void ShitToLeft()
        {  
        }

        public void Dequeue()
        {
            if (front == rear)
            {
                Console.WriteLine("The Queue is empty");
                return;
            }
            else
            {

                for (int i = 1; i < rear; i++)
                {
                    array[i - 1] = array[i];
                }
            }

           rear--;

        }

        public void Print()
        {
            if(front == rear)
            {
                Console.WriteLine("The Queue is empty");
                return;
            }
            StringBuilder sb = new StringBuilder("[");
            for (int i = front; i < rear; i++)
            {
                sb.Append(array[i]);
                if (i < rear-1)
                {
                    sb.Append(", ");
                }
            }
            sb.Append("]");
            Console.WriteLine(sb.ToString());
        }
    }
}

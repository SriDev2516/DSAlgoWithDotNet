using System;
using System.Collections.Generic;
using System.Text;

namespace QueueImplementation
{
    public class QueueWithLinkedList
    {
        Node head;
        public void Print()
        {

            if(head == null)
            {
                Console.WriteLine("The queue is empty");
                return;
            }
            StringBuilder sb = new StringBuilder("[");
            Node currentNode = head;
            while (currentNode != null)
            {
                sb.Append(currentNode.data.ToString());
                if(currentNode.next != null)
                {
                    sb.Append(", ");
                }
                currentNode = currentNode.next;
            }
            sb.Append("]");
            Console.WriteLine(sb.ToString());
        }

        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if(head == null)
            {
                head = newNode;
            }
            else
            {
                Node tempNode = head;
                while(tempNode.next != null)
                {
                    tempNode = tempNode.next;
                }
                tempNode.next = newNode;
            }
        }

        public void Dequeue()
        {
            if(head == null)
            {
                Console.WriteLine("The queue is empty");
            }
            else
            {
                head = head.next;
            }
        }

    }

    class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.next = null;
            this.data = data;
        }
    }
}

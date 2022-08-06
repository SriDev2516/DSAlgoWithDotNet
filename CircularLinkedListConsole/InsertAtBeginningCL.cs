using System;
using System.Collections.Generic;
using System.Text;

namespace CircularLinkedListConsole
{
    public class InsertAtBeginningCL
    {
        Node head;
        public void AddFirst(int data)
        {
            Node newNode = new Node(data);

            if (head== null)
            {
                newNode.next = newNode;
                head = newNode;
            }
            else
            {
                Node last = head;
                while(last.next != head)
                {
                    last = last.next;
                }
                last.next = newNode;
                newNode.next = head;
                head = newNode;
            }
        }

        public void Print()
        {
            var tempNode = head;
            do
            {
                Console.WriteLine(tempNode.data.ToString());
                tempNode = tempNode.next;

            } while (tempNode != head);

            Console.WriteLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CircularLinkedListConsole
{
    public class InsertAtEndCL
    {
        Node head;
        public void AddLast(int data)
        {
            Node newNode = new Node(data);

            if(head == null)
            {
                newNode.next = newNode;
                head = newNode;
            }
            else
            {
                Node last = head;
                while (last.next != head)
                {
                    last = last.next;

                }
                last.next = newNode;
                newNode.next = head;
            }
        }

        public void Print()
        {
            var tempNode = head;
            do
            {
                Console.WriteLine(tempNode.data);
                tempNode = tempNode.next;
            } while (tempNode != head);
        }
    }
}

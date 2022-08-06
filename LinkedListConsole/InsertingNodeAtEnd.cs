using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListConsole
{
    public class InsertingNodeAtEnd
    {
        Node head;

        public void AddLast(int data)
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = null;

            if(head == null)
            {
                head = newNode;
            }
            else
            {
                Node lastNode = head;
                while(lastNode.next != null)
                {
                    lastNode = lastNode.next;
                }

                lastNode.next = newNode;
            }

            Utility.DisplayLinkedList(head);
        }



    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListConsole
{
    public class InsertAtBeginning
    {
        Node head;

        public Node AddFirst(int data)
        {
            var newNode = new Node();

            if (head == null)
            {
                newNode.data = data;
                newNode.next = null;
            }
            else
            {
                newNode.data = data;
                newNode.next = head;

            }
            head = newNode;

            return head;


        }
    }
}

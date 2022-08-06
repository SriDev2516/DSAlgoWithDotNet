using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedListConsole
{
    public class AddBeginningDoublyList
    {
        Node head;
        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.prev = null;
                newNode.next = head; 
                head.prev = newNode;
                head = newNode;
            }
        }

        public void ForwardPrint()
        {
            ForwardTraversal.Print(head);
        }

        public void BackwardPrint()
        {
            Node last = GetLastNode(head);
            if(last != null)
            {
                BackWardTraversal.Print(last);

            }
        }

        private Node GetLastNode(Node head)
        {
            var tempNode = head;
            Node last = null;
            while(tempNode != null)
            {
                if (tempNode.next == null)
                {
                    last = tempNode;
                    break;
                }
                tempNode = tempNode.next;
            }
            return last;
        }
    }
}

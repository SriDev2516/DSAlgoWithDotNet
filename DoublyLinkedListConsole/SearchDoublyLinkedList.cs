using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedListConsole
{
    public class SearchDoublyLinkedList
    {
        Node head;

        public void InsertAtLast(int data)
        {
            var newNode = new Node(data);
            if(head == null)
            {
                head = newNode;
            }
            else
            {
                var tempNode = head;
                while (tempNode.next != null)
                {
                    tempNode = tempNode.next;
                }
                tempNode.next = newNode;
                newNode.prev = tempNode;
            }
        }
        public void Search(int key)
        {
            string result = "Key Does not exist";

            if(head == null)
            {
                result = "Linked list is empty";
            } else
            {
                var tempNode = head;
                while (tempNode.next!=null)
                {
                    if (tempNode.data == key)
                    {
                       result = "Key exists!!";
                    }
                    tempNode = tempNode.next;
                }
            }

            Console.WriteLine(result);
        }

        public void ForwardPrint()
        {
            ForwardTraversal.Print(head);
        }

        public void BackwardPrint()
        {
            Node last = GetLastNode(head);
            if (last != null)
            {
                BackWardTraversal.Print(last);

            }
        }

        private Node GetLastNode(Node head)
        {
            var tempNode = head;
            Node last = null;
            while (tempNode != null)
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

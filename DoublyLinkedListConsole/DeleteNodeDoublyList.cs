using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedListConsole
{
    public class DeleteNodeDoublyList
    {
        Node head;

        public void InsertAtLast(int data)
        {
            var newNode = new Node(data);
            if (head == null)
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

        public void Delete(int key)
        {
            if(head.data == key)
            {
                head = head.next;
                head.prev = null;
            }
            else
            {
                var tempNode = head;
                while (tempNode.next!=null)
                {
                    if(tempNode.next.data == key)
                    {
                        var nextNode = tempNode.next.next;
                        tempNode.next = nextNode;
                        nextNode.prev = tempNode;
                    }
                    else
                    {
                        tempNode = tempNode.next;

                    }
                }
            }
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

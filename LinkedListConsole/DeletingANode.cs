using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListConsole
{
    public class DeletingANode
    {
        Node head;

        public void Delete(int data)
        {
            if(head.data == data)
            {
                head = head.next;
            } else
            {
                Node currentNode = head;
                while (currentNode.next != null)
                {
                    if(currentNode.next.data == data)
                    {
                        currentNode.next = currentNode.next.next;
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.next;
                    }
                }
            }

            Utility.DisplayLinkedList(head);

        }

        public void AddLast(int data)
        {
            var newNode = new Node();
            newNode.data = data;
            newNode.next = null;

            if(head == null)
            {
                head = newNode;
            } else
            {
                var tempNode = head;
                while(tempNode.next != null)
                {
                    tempNode = tempNode.next;
                }

                tempNode.next = newNode;
            }
        }

        public void PrintNodes()
        {
            Utility.DisplayLinkedList(head);
        }
    }
}

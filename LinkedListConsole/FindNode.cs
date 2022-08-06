using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListConsole
{
    
    public class FindNode
    {
        Node head;

        private const string ITEM_EXISTS = "Item Exists";
        private const string ITEM_DOES_EXISTS = "Item Does Not Exist";
        private const string LIST_IS_EMPTY = "List Is Empty";

        public void AddLast(int data)
        {
            var newNode = new Node() { data = data, next = null };
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node currentNode = head;
                while (currentNode.next!=null)
                {
                    currentNode = currentNode.next;
                }
                currentNode.next = newNode;
            }

            
        }

        public void AddFirst(int data)
        {
            var newNode = new Node() { data = data, next = null };
            if (head == null)
            {
                head= newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }

            
        }

        public void Delete(int data)
        {
            if(head.data == data)
            {
                head = head.next;
            }
            else
            {
                Node tempNode = head;
                while(tempNode.next != null)
                {
                    if(tempNode.next.data == data)
                    {
                        tempNode.next = tempNode.next.next;
                        break;
                    }
                    else
                    {
                        tempNode = tempNode.next;
                    }
                }
            }

        }

        public void Print()
        {
            Utility.DisplayLinkedList(head);
        }

        public void Search(int data)
        {
            string result = ITEM_DOES_EXISTS;
            if(head == null)
            {
                result = LIST_IS_EMPTY;
            } else
            {
                Node tempNode = head;
                while (tempNode != null)
                {
                    if (tempNode.data == data)
                    {
                        result = ITEM_EXISTS;
                        break;
                    }
                    tempNode = tempNode.next;
                }
            }

            Console.WriteLine(result);
        }
    }
}

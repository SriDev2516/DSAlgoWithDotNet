using System;
using System.Collections.Generic;
using System.Text;

namespace CircularLinkedListConsole
{
    public class DeleteANodeCL
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
                do
                {
                    last = last.next;
                }while(last.next != head);
                last.next = newNode;
                newNode.next = head;
                head = newNode;
            }
        }

        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                newNode.next = newNode;
                head = newNode;
            }
            else
            {
                newNode.next = head;
                
                Node last = head;
                do
                {
                    last = last.next;
                } while (last.next != head);
                head = newNode;
                last.next = head;
            }
        }

        public void print()
        {
            Node last = head;
            do
            {
                Console.WriteLine(last.data);
                last = last.next;
            } while (last != head);
        }

        public void Delete(int key)
        {
            var last = head;

            do
            {
                if (last.next.data == key)
                {
                    last.next = last.next.next;
                    break;
                }
                else
                {
                    last = last.next;
                }
            } while (last.next != head);
        }
    }
}

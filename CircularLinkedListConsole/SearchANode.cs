using System;
using System.Collections.Generic;
using System.Text;

namespace CircularLinkedListConsole
{
    public class SearchANode
    {
        Node head;

        public void print()
        {
            var currentNode = head;
            do
            {
                Console.WriteLine(currentNode.data.ToString());
                currentNode = currentNode.next;
            } while (currentNode != head);
        }

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
                var last = head;
                while(last.next != head)
                {
                    last = last.next;
                }

                last.next = newNode;
                newNode.next = head;
            }
        }

        public void AddFirst(int data)
        {
            var newNode = new Node(data);
            if (head == null)
            {
                newNode.next = newNode;
                head = newNode;
            }
            else
            {
                var last = head;
                while(last.next != head)
                {
                    last = last.next;
                }
                newNode.next = head;
                head = newNode;
                last.next = newNode;
            }
        }

        internal void Search(int key)
        {
            var last = head;
            while(last.next != head)
            {
                if(last.data == key)
                {
                    Console.WriteLine("Key Exists");
                    return;
                }
                last = last.next;
            }

            Console.WriteLine("Key does not exist");

        }
    }
}

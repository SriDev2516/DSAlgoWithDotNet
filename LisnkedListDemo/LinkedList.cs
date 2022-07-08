using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    public class LinkedList
    {
        public LinkedListNode head = null;

        public LinkedList()
        {

        }

        public void InsertAtHead(int data)
        {
            if (this.head == null)
            {
                this.head = new LinkedListNode(data);
            }
            else
            {
                var currentNode = this.head;
                var newNode = new LinkedListNode(data);

                newNode.next = this.head;
                this.head = newNode;
            }
        }

        public void InsertAtTail(int data)
        {
            if(this.head == null)
            {
                this.head = new LinkedListNode(data);
            }
            else
            {
                var currentNode = this.head;
                while(currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }
                var newNode = new LinkedListNode(data);
                currentNode.next = newNode;
            }
        }

        public LinkedListNode GetHead()
        {
            return this.head;
        }

        public void DiaplayLinkedList(LinkedListNode head)
        {
            if (head == null)
            {
                return;
            }

            StringBuilder sb = new StringBuilder("[ ");
            var currentNode = head;

            while(currentNode != null)
            {
                sb.Append(currentNode.data);
                if(currentNode.next != null)
                {
                    sb.Append(", ");
                }
                currentNode = currentNode.next;
            }

            sb.Append(" ]");
            Console.WriteLine(sb.ToString());
        }


    }
}

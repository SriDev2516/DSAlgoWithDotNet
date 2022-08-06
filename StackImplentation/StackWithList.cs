using System;
using System.Collections.Generic;
using System.Text;

namespace StackImplentation
{
    public class StackWithList
    {
        Node head;
        public void Push(int data)
        {
            Node newNode = new Node(data);
            if(head == null)
            {
                head = newNode;
            }
            else
            {
                var tempNode = head;
                while(tempNode.next != null)
                {
                    tempNode = tempNode.next;
                }
                tempNode.next = newNode;
            }
        }

        public void Pop()
        {
            var tempNode = head;
            while (tempNode.next.next != null)
            {
                tempNode = tempNode.next;
            }
            tempNode.next = null;
        }

        public void Print()
        {
            StringBuilder sb = new StringBuilder("[");
            var tempNode = head;
            while (tempNode != null)
            {
                sb.Append(tempNode.data);
                if(tempNode.next != null)
                {
                    sb.Append(", ");
                }
                tempNode = tempNode.next;
            }
            sb.Append("]");
            Console.WriteLine(sb.ToString());
        }
    }

    class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
}

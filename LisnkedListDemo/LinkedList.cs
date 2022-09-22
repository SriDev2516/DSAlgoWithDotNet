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

        public void CreateLinkedList(List<int> list)
        {
            if (list.Count() != 0)
            {
                foreach (var data in list)
                {
                    InsertAtTail(data);
                }
            }
        }

        public LinkedListNode CreateLinkedlIst(int[] arr)
        {
            LinkedListNode head = null;
            LinkedListNode tail = null;
            for (int i = 0; i < arr.Length; i++)
            {
                var newNode = new LinkedListNode(arr[i]);
                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    tail.next = newNode;
                }
                tail = newNode;
            }

            return tail;
        }

        public LinkedListNode ReverseLinkedList(LinkedListNode head)
        {
            if (head == null || head.next == null) return head;
            LinkedListNode curr = head;
            LinkedListNode prev = null;

            while (curr != null)
            {
                var temp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = temp;
            }
            this.head = prev;
            return prev;
        }

        public LinkedListNode RemoveDuplicates(LinkedListNode head)
        {
            if (head == null || head.next == null)
                return head;

            var nums = new List<int>();
            nums.Add(head.data);
            var curr = head;

            while(curr.next != null)
            {
                if (nums.Contains(curr.next.data))
                {
                    curr.next = curr.next.next;
                }
                else
                {
                    nums.Add(curr.next.data);
                    curr = curr.next;
                }
            }

            return head; 
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

        public LinkedListNode AddTwoLinkedLists(LinkedListNode l1, LinkedListNode l2)
        {
            Queue<int> s1 = new Queue<int>();
            while(l1 != null)
            {
                s1.Enqueue(l1.data);
                l1 = l1.next;
            }

            Queue<int> s2 = new Queue<int>();
            while (l2 != null)
            {
                s2.Enqueue(l2.data);
                l2 = l2.next;
            }

            int carry = 0;
            LinkedListNode head = null;
            LinkedListNode tail = null;
            while(s1.Count() != 0 || s2.Count() != 0)
            {
                var n1 = s1.Count() == 0  ? 0 : s1.Dequeue(); 
                var n2 = s2.Count() == 0  ? 0 : s2.Dequeue();

                var sum = ((n1 + n2 + carry)%10);
                if (n1 + n2 > 9)
                {
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }
                var newNode = new LinkedListNode(sum);


                if (head == null) {
                    head = newNode;
                }
                else
                {
                    tail.next = newNode;
                }

                
            }

            return tail;
        }
    }
}

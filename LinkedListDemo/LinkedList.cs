using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    public class LinkedList
    {

        public LinkedListNode head;

        public LinkedList()
        {
            this.head = null;
        }

        public void insertAtHead(int data)
        {
            if (this.head == null)
            {
                this.head = new LinkedListNode(data);
            } else
            {
                var tempNode = new LinkedListNode(data);
                tempNode.next = this.head;
                this.head = tempNode;
            }
        }

        public void insertAtTail(int data)
        {
            if (this.head == null)
            {
                this.head = new LinkedListNode(data);
                return;
            }
            var temp = this.head;

            while (temp.next != null)
            {
                temp = temp.next;
            }
            var newNode = new LinkedListNode(data);
            temp.next = newNode;
        }

        public void createLinkedList(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count(); i++)
            {
                insertAtTail(numbers[i]);
            }

            
        }

        public void reverseLinkedList(LinkedListNode head)
        {
            LinkedListNode? listToDo = this.head.next;
            var reversed = this.head;
            reversed.next = null;

            while (listToDo != null)
            {
                if (listToDo.next == null)
                {
                    this.head = listToDo;
                }
                var temp = listToDo;
                listToDo = listToDo.next;

                temp.next = reversed;
                reversed = temp;
            }
        }

        public void removeDuplicates(LinkedListNode head)
        {
            if (head == null)
            {
                return;
            }
            HashSet<int?> dupSet = new HashSet<int?>();
            dupSet.Add(head.data);
            LinkedListNode curr = head;
            while (curr.next != null)
            {
                if (dupSet.Contains(curr.next.data))
                {
                    curr.next = curr.next.next;
                } else
                {
                    dupSet.Add(curr.next.data);
                    curr = curr.next;
                }
            }

        }
        public LinkedListNode reverseWithRecursion(LinkedListNode head)
        {
         //   [100, 10, 20, 30]
            if (head == null || head.next == null)
            {
                this.head = head;
                return head;
            }

            LinkedListNode reversedList = reverseWithRecursion(head.next);
            head.next.next = head;
            head.next = null;


            return reversedList;
        }

        public LinkedListNode deleteNode(LinkedListNode head, int key)
        {
           
                // TODO: Write - Your - Code
                LinkedListNode curr = head;
                LinkedListNode prev = null;

                while (curr != null)
                {
                    if (curr.data == key)
                    {
                    if (curr == head)
                    {
                        head = head.next;
                        this.head = head;
                        curr = head;
                    }
                    else {
                        prev.next = curr.next;
                        curr=curr.next;
                    }
                    } else
                    {
                    prev = curr;
                    curr = curr.next;
                    }
                }
                return head;
            }
        

        public  void displayLinkedList()
        {
            var temp = this.head;
            StringBuilder res = new StringBuilder("[");

            while(temp != null)
            {
                res.Insert(res.Length, temp.data);
                temp = temp.next;
                if (temp != null)
                {
                    res.Insert(res.Length, ", ");
                }
            }

            res.Insert(res.Length, "]");

            Console.WriteLine(res.ToString());

            
        }
    }
}

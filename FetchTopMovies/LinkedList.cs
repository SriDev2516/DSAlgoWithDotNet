using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;

namespace FetchTopMovies
{
    public  class LinkedList
    {
        public static LinkedListNode InsertAtHead(int data, LinkedListNode head)
        {
            var newNode = new LinkedListNode(data);
            if(head == null)
            {
                return newNode;
            }
            newNode.next = head;
            return newNode;
        }

        public static LinkedListNode InsertAtTail(int data, LinkedListNode head)
        {
            var newNode = new LinkedListNode(data);
            if(head == null)
            {
                return newNode;
            }
            var tempNode = head;
            while (tempNode.next != null)
            {
                tempNode = tempNode.next;
            }

            tempNode.next = newNode;
            return head;
        }

        public static LinkedListNode InsertAtTail(LinkedListNode head, LinkedListNode node)
        {
            if(head != null)
            {
                return node;
            }

            var temp = head;
            while(temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = node;
            return head;
        }

        public static LinkedListNode CreateLinkedList(List<int> list)
        {
            LinkedListNode head = null;
            LinkedListNode tail = null;
            foreach (var item in list)
            {
                LinkedListNode newNode = new LinkedListNode(item);
                if (head == null)
                {
                    head =  newNode;
                }
                else
                {
                    tail.next = newNode;
                }
                tail = newNode;
            }
            return head;
        }

        public static LinkedListNode CreateLinkedList(int[] arr)
        {
            LinkedListNode head = null;
            LinkedListNode tail = null;

            for(int i=0; i<arr.Length; i++)
            {
                var newNode = new LinkedListNode(arr[i]);
                if(head == null)
                {
                    head = newNode;
                }
                else
                {
                    tail.next = newNode;
                }
                tail = newNode;
            }

            return head;
        }

        public static LinkedListNode CreateRandomList(int length)
        {
            LinkedListNode head = null;
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                var data = random.Next(100);
                head = InsertAtHead(data, head);
            }

            return head;
        }

        public static List<int> ToList(LinkedListNode head)
        {
            List<int> list = new List<int>();
            var temp = head;
            while (temp.next != null)
            {
                list.Add(temp.data);
                temp = temp.next;
            }

            return list;
        }

        public static void Display(LinkedListNode head)
        {
            if(head == null)
            {
                Console.WriteLine($"The List is empty");
                return;
            }

            StringBuilder sb = new StringBuilder("[");
            var temp = head;
            while (temp!=null)
            {
                sb.Append(temp.data);
                if(temp.next != null)
                {
                    sb.Append(", ");
                }
                temp = temp.next;
            }
            sb.Append("]");
            Console.WriteLine(sb.ToString());
        }

        public static bool IsEqual(LinkedListNode list1, LinkedListNode list2)
        {
            if (list1 == list2) return true;

            while(list1.next != null && list2.next != null)
            {
                if(list1.data != list2.data)
                {
                    return false;
                }

                list1 = list1.next;
                list2 = list1.next;
            }

            return (list1 == list2);
        }

        public static LinkedListNode MergeAlternating(LinkedListNode list1, LinkedListNode list2)
        {
            LinkedListNode dummy = new LinkedListNode(-1);

            LinkedListNode prev = dummy;

            while (list1 !=null && list2 !=null)
            {
                if (list1.data <= list2.data)
                {
                    prev.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    prev.next = list2;
                    list2 = list2.next;
                }

                prev = prev.next; 
            }

            if (list1 == null)
            {
                prev.next = list2;
            }
            else
            {
                prev.next = list1;
            }

            return dummy.next;

        }

        public static LinkedListNode Sort(LinkedListNode head)
        {
                var temp = head;
                LinkedListNode sortedList = new LinkedListNode(head.data);
                sortedList.next = null;
                
                while (temp.next != null)
                {
                    var rempSort = sortedList;
                    while (rempSort.next == null)
                    {
                        if (rempSort.data < temp.data && temp.data < rempSort.next.data)
                        {
                            var current = rempSort.next;
                            rempSort.next = temp;
                            temp.next = current;
                            rempSort = current;
                            continue;
                        }

                        else if (temp.data < rempSort.data)
                        {
                            temp.next = rempSort;
                            rempSort = rempSort.next;
                            continue;
                        }

                        else if(temp.data >  rempSort.data)
                        {
                            rempSort.next = temp;
                            rempSort = rempSort.next;
                            continue;
                        }

                    }

                    temp = temp.next;
                }

                return sortedList;
            }
        }
    
}

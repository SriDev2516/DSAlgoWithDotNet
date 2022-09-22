using System;

namespace AddTwoNumbers
{

    public class ListNode
    {
      public int val;
      public ListNode next;
      public ListNode(int val = 0)
       {
           this.val = val;
           this.next = null;
       }
    }

    public class LinkedList
    {
        public ListNode head;
        public ListNode createLinkedList(int[] arr, ListNode head)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(head == null)
                {
                    head = new ListNode(arr[i]);
                }
                else
                {
                    var temp = head;
                    while(temp.next != null)
                    {
                        temp = temp.next;
                    }
                    var newNode = new ListNode(arr[i]);
                    temp.next = newNode;
                }
            }

            return head;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList l = new LinkedList();

            var l1 =l.createLinkedList(new int[] { 5, 6 }, null);
            var l2 =l.createLinkedList(new int[] { 5, 4, 9 }, null);
            AddTwoNumbers(l1, l2); // 0 1 0 1
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            
            ListNode head = new ListNode(-1);
            int carry = 0;
            var curr = head;
            while (l1 != null || l1 != null || carry != 0)
            {
                int x = l1?.val ?? 0;
                int y = l2?.val ?? 0; 

                var sum = x + y + carry;
                carry = sum / 10;
                var val = sum % 10;
                curr.next = new ListNode(val);

                curr = curr.next;
                l1 = l1?.next;
                l2 = l2?.next;
            }
            return head.next;
        }

    }


       
    
}

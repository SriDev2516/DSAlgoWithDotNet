using System;

namespace MergeTwoSortedLists21
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            var list1 = linkedList.CreateListFromArray(new int[] { 1, 2, 4 });
            var list2 = linkedList.CreateListFromArray(new int[] { 0, 1, 3, 4 });

            linkedList.DisplayLinkedList(MergeTwoLists(list1, list2));
        }
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null && list2 == null) return null;
            if (list1 == null) return list2;
            if (list2 == null) return list1;

            ListNode newList = new ListNode(-1);
            ListNode node = newList;

            while(list1 != null && list2 != null)
            {
                if(list1.val < list2.val)
                {
                    node.next = list1;
                    list1 = list1.next;
                    node = node.next;
                }
                else
                {
                    node.next = list2;
                    list2 = list2.next;
                    node = node.next;
                }
            }

            while(list1!= null)
            {
                node.next = list1;
                list1 = list1.next;
                node = node.next;
            }

            while(list2 != null)
            {
                node.next = list2;
                list2 = list2.next;
                node = node.next;
            }

            return newList.next;
        }
    }
}

using LinkedListDemo;
using System;
using System.Collections.Generic;

namespace LisnkedListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            
            list.CreateLinkedList(new List<int> { 1,1,2,33,3,3, 1235, 2, 1237 });
            // list.ReverseLinkedList();
            var head = list.GetHead();
            list.DiaplayLinkedList(head);
            list.ReverseLinkedList(list.GetHead());

            list.DiaplayLinkedList(list.GetHead());
            var head1 = list.RemoveDuplicates(list.GetHead());
            list.DiaplayLinkedList(head1);

            var l1 = list.CreateLinkedlIst(new int[] { 1, 3, 4 });
            var l2 = list.CreateLinkedlIst(new int[] { 1, 3, 4 });

            var result = list.AddTwoLinkedLists(l1, l2);


        }
    }
}

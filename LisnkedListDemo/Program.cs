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

            list.InsertAtHead(100);
            list.InsertAtHead(200);
            list.InsertAtHead(100);
            list.InsertAtHead(100);
            list.InsertAtHead(300);
            list.InsertAtHead(800);
            list.InsertAtTail(1000);
            list.CreateLinkedList(new List<int> { 1234, 1235, 1236, 1237 });
            list.ReverseLinkedList();
            var head = list.GetHead();
            list.DiaplayLinkedList(head);


        }
    }
}

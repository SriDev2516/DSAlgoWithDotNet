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

            
            list.CreateLinkedList(new List<int> { 1234, 1235, 1236, 1237 });
            // list.ReverseLinkedList();
            var head = list.GetHead();
            list.DiaplayLinkedList(head);


        }
    }
}

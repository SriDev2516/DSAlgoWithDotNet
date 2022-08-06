using System;

namespace DoublyLinkedListConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Node first = new Node();
            //Node middle = new Node();
            //Node last = new Node();
            //Node head;

            //first.data = 10;
            //middle.data = 20;
            //last.data = 30;

            //first.next = middle;
            //middle.next = last;
            //last.next = null;

            //first.prev = null;
            //middle.prev = first;
            //last.prev = middle;

            //ForwardTraversal.Print(first);
            //Console.WriteLine();
            //BackWardTraversal.Print(last);

            //head = first;

            //SearchDoublyLinkedList searchDoublyLinkedList = new SearchDoublyLinkedList();
            //searchDoublyLinkedList.InsertAtLast(100);
            //searchDoublyLinkedList.InsertAtLast(200);
            //searchDoublyLinkedList.InsertAtLast(300);
            //searchDoublyLinkedList.InsertAtLast(500);
            //searchDoublyLinkedList.InsertAtLast(600);

            //searchDoublyLinkedList.ForwardPrint();
            //searchDoublyLinkedList.BackwardPrint();

            //searchDoublyLinkedList.Search(400);
            //searchDoublyLinkedList.Search(500);

            DeleteNodeDoublyList deleteNode = new DeleteNodeDoublyList();
            deleteNode.InsertAtLast(120);
            deleteNode.InsertAtLast(200);
            deleteNode.InsertAtLast(300);
            deleteNode.InsertAtLast(500);
            deleteNode.InsertAtLast(600);

            deleteNode.ForwardPrint();
            deleteNode.BackwardPrint();

            deleteNode.Delete(300);
            Console.WriteLine();

            deleteNode.ForwardPrint();
            deleteNode.BackwardPrint();

        }
    }
}

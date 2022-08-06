using System;

namespace CircularLinkedListConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Node head = new Node(10);
            //Node middle = new Node(20);
            //Node last = new Node(30);

            //head.next = middle;
            //middle.next = last;
            //last.next = head;

            //InsertAtBeginningCL insertAtBeginningCL = new InsertAtBeginningCL();
            //insertAtBeginningCL.AddFirst(90);
            //insertAtBeginningCL.AddFirst(80);
            //insertAtBeginningCL.AddFirst(60);
            //insertAtBeginningCL.AddFirst(100);

            //insertAtBeginningCL.Print();

            //InsertAtEndCL insertAtEndCL = new InsertAtEndCL();

            //insertAtEndCL.AddLast(10);
            //insertAtEndCL.AddLast(230);

            //insertAtEndCL.Print();

            //SearchANode searchANode = new SearchANode();
            //searchANode.AddLast(90);
            //searchANode.AddLast(70);
            //searchANode.AddLast(80);
            //searchANode.AddFirst(10);
            //searchANode.print();
            //searchANode.Search(190);

            DeleteANodeCL deleteANodeCL = new DeleteANodeCL();
            deleteANodeCL.AddLast(180);
            deleteANodeCL.AddLast(170);
            deleteANodeCL.AddLast(160);
            deleteANodeCL.AddLast(150);
            deleteANodeCL.print();
            Console.WriteLine();
            deleteANodeCL.AddFirst(100);
            deleteANodeCL.print();
            Console.WriteLine();
            deleteANodeCL.Delete(160);
            deleteANodeCL.print();





        }
    }
}

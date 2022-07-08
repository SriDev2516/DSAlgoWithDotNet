using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    public class Test
    {

        static void Main()
        {
            LinkedList linkedList = new LinkedList();

            linkedList.insertAtHead(10);
            linkedList.insertAtHead(10);
            linkedList.insertAtHead(10);
            linkedList.insertAtHead(10);
            linkedList.insertAtHead(10);
            linkedList.insertAtHead(10);
            linkedList.insertAtHead(10);
            linkedList.insertAtHead(10);
            linkedList.insertAtHead(10);
            linkedList.insertAtHead(10);
            linkedList.insertAtTail(1000);
            linkedList.createLinkedList(new List<int> { 10});
            linkedList.GetHead();
            linkedList.RemoveDuplicatesTest(linkedList.GetHead());
            linkedList.displayLinkedList();



        }
    }
}

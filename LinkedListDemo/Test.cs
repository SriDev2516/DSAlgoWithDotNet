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
            linkedList.insertAtHead(20);
            linkedList.insertAtHead(30);

            linkedList.insertAtTail(100);                      

            linkedList.displayLinkedList();

            linkedList.reverseLinkedList(linkedList.head);

            linkedList.displayLinkedList();

            linkedList.reverseWithRecursion(linkedList.head);

            linkedList.displayLinkedList();

        }
    }
}

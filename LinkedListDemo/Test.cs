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
            linkedList.insertAtHead(20);
            linkedList.insertAtTail(10);                      

            linkedList.displayLinkedList();

            // linkedList.removeDuplicates(linkedList.head);


            linkedList.deleteNode(linkedList.head, 20);

            linkedList.displayLinkedList();


        }
    }
}

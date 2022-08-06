using DoublyLinkedListConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedListConsole
{
    public class ForwardTraversal:IPrint
    {
        public static void Print(Node first)
        {
            StringBuilder stringBuilder = new StringBuilder("[");
            var tempNode = first;
            while (tempNode != null)
            {
                stringBuilder.Append(tempNode.data.ToString());
                if (tempNode.next != null)
                {
                    stringBuilder.Append(", ");
                }
                tempNode = tempNode.next;
            }
            stringBuilder.Append("]");
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}

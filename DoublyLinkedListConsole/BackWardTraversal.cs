using DoublyLinkedListConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedListConsole
{
    internal class BackWardTraversal : IPrint
    {
        public static void Print(Node last)
        {
            StringBuilder stringBuilder = new StringBuilder("[");
            var tempNode = last;
            while (tempNode != null)
            {
                stringBuilder.Append(tempNode.data.ToString());
                if (tempNode.prev != null)
                {
                    stringBuilder.Append(", ");
                }
                tempNode = tempNode.prev;
            }
            stringBuilder.Append("]");
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}

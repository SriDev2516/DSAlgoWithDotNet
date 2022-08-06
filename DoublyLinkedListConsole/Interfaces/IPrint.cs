using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedListConsole.Interfaces
{
    internal interface IPrint
    {
        static void Print(Node node)
        {
            Console.WriteLine(node.ToString());
        }
    }
}

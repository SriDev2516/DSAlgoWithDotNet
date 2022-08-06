using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedListConsole
{
    public class Node
    {
        public Node prev { get; set; }
        public int data { get; set; }
        public Node next { get; set; }

        public Node(int data)
        {
            this.prev = null;
            this.data = data;
            this.next = null;
        }
    }
}

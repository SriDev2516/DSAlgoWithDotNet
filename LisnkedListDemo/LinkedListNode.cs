using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    public class LinkedListNode
    {
        public int data { get; set; }
        public LinkedListNode next { get; set; }
        public LinkedListNode prev { get; set; }
        public LinkedListNode arbitrary { get; set; }

        public LinkedListNode(int data)
        {
            this.data = data;
            this.next = null;
            this.prev = null;
            this.arbitrary = null;
        }
    }
}

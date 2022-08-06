using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListConsole
{
    public class Utility
    {
        public static void DisplayLinkedList(Node head)
        {
            StringBuilder sb = new StringBuilder("[");
            var temp = head;
            while (temp!= null)
            {
                sb.Append(temp.data.ToString());
                if(temp.next != null)
                {
                    sb.Append(", ");
                }
                temp = temp.next;
            }
            sb.Append("]");
            Console.WriteLine(sb.ToString());
        }
    }
}

using System;

namespace LinkedListConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindNode findNode = new FindNode();
            findNode.Search(2000);

            findNode.AddFirst(12);
            findNode.AddFirst(16);
            findNode.AddFirst(1100);
            findNode.AddFirst(11);
            findNode.AddFirst(119);

            findNode.AddLast(100);
            findNode.AddLast(500);
            findNode.AddLast(5000);
            findNode.Print();

            findNode.Delete(500);
            findNode.Print();
            findNode.Search(5000);
          

        }
    }
}

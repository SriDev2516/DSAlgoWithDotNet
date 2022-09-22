using System;

namespace FetchTopMovies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list1 = LinkedList.CreateLinkedList(new int[] { 11, 41, 1 });
            var list2 = LinkedList.CreateLinkedList(new int[] { 21, 23, 2 });

            var result =  LinkedList.MergeAlternating(list1, list2);

            LinkedList.Display(result);

            Console.WriteLine("After Sort");

            LinkedList.Sort(list1);
        }
    }
}

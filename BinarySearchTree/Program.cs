using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bt = new BinarySearchTree(10);
            Console.WriteLine($"Created a binary search tree with root {bt.GetRoot().value}");

        }
    }
}

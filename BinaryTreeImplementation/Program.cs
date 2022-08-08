using System;

namespace BinaryTreeImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            SearchBST bst = new SearchBST();
            bst.root = bst.Insert(bst.root, 100);
            bst.root = bst.Insert(bst.root, 30);
            bst.root = bst.Insert(bst.root, 200);
            bst.root = bst.Insert(bst.root, 300);
            bst.root = bst.Insert(bst.root, 50);
            bst.root = bst.Insert(bst.root, 20);
            bst.root = bst.Insert(bst.root, 900);
            bst.root = bst.Insert(bst.root, 500);

            bst.Inorder(bst.root);

            if(bst.Search(bst.root, 2000))
            {
                Console.WriteLine("Key found");
            }
            else
            {
                Console.WriteLine("Key not found");
            }
        }
    }
}

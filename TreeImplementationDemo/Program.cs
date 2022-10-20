using BinaryTreeImplementation;
using System;
using System.Collections.Generic;

namespace TreeImplementationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.root = bst.Insert(bst.root, 100);
            bst.root = bst.Insert(bst.root, 30);
            bst.root = bst.Insert(bst.root, 200);
            bst.root = bst.Insert(bst.root, 300);
            bst.root = bst.Insert(bst.root, 50);
            bst.root = bst.Insert(bst.root, 20);
            bst.root = bst.Insert(bst.root, 900);
            bst.root = bst.Insert(bst.root, 500);

            var result1 =  bst.InOrderTraverseIteration(bst.root);
            DisplayResult(result1);
            var result2 = bst.InorderTraversalWithRecursion(bst.root);
            DisplayResult(result2);
            var preorderResultWithRecrusion = bst.PreOrderTraversalWithRecrusion(bst.root);
            DisplayResult(preorderResultWithRecrusion);
            var preorderResultWithIteration = bst.PreOrderTraversalWithIteration(bst.root);
            DisplayResult(preorderResultWithIteration);
            var postOrderTraversalWithIteration = bst.PostOrderTraversalWithIteration(bst.root);
            DisplayResult(postOrderTraversalWithIteration);
            var postOrderTraversalWithRecursion = bst.PostOrderTraversalWithRecursion(bst.root);
            DisplayResult(postOrderTraversalWithRecursion);

        }

        private static void DisplayResult(List<int> list)
        {
            foreach (var data in list)
            {
                Console.Write(data + ",");
            }
            Console.WriteLine();
        }
    }
}

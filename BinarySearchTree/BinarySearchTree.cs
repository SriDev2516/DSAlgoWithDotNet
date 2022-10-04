using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class BinarySearchTree
    {
        Node root;
        public BinarySearchTree()
        {
            root = null;
        }
        public BinarySearchTree(int rootValue)
        {
            root = new Node(rootValue);
        }

        public Node GetRoot()
        {
            return root;
        }
    }
}

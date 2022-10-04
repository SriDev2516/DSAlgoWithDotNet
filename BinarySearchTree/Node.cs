using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class Node
    {
        public int value;
        public Node left;
        public Node right;

        public Node()
        {
            value = 0;
            left = null;
            right = null;
        }

        public Node(int val)
        {
            value = val;
            right = null;
            left = null;
        }
    }
}

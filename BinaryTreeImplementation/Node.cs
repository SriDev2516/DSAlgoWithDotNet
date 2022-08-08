using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeImplementation
{
    public class Node
    {
        public int data;
        public Node right;
        public Node left;

        public Node(int key)
        {
            this.data = key;
            this.right = null;
            this.left = null;
        }
    }
}

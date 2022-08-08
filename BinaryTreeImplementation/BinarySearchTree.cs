using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeImplementation
{
    public class BinarySearchTree
    {
        public Node root;
        public Node Insert(Node root, int val)
        {
            if(root == null)
            {
                return new Node(val);
            }
            else if(root.data > val)
            {
                root.left = Insert(root.left, val);
            }
            else if(root.data < val)
            {
               root.right = Insert(root.right, val);
            }

            return root;
        }
    }
}

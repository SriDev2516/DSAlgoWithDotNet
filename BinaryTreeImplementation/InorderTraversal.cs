using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeImplementation
{
    public class InorderTraversal
    {
        public Node root;
        public Node Insert(Node root, int val)
        {
            if(root == null)
            {
                root = new Node(val);
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

        public void Inorder(Node root)
        {
            if(root == null)
            {
                return;
            }

            Inorder(root.left);
            Console.WriteLine(root.data);
            Inorder(root.right);

        }
    }
}

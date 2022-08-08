using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeImplementation
{
    public class SearchBST
    {
        public Node root;
        public Node Insert(Node root, int value)
        {
            if(root == null)
            {
                root = new Node(value);
            }else if(value < root.data)
            {
                root.left = Insert(root.left, value);
            } else if(value > root.data)
            {
                root.right = Insert(root.right, value); 
            }
            return root;
        }

        public void Inorder(Node root)
        {
            if (root == null)
                return;

            Inorder(root.left);
            Console.WriteLine(root.data);
            Inorder(root.right);
        }

        public bool Search(Node root, int val)
        {
            if (root == null)
                return false;
            else if (root.data == val)
            {
                return true;
            }
            else if (val < root.data)
            {
                return Search(root.left, val);
            }
            else
            {
                return Search(root.right, val);
            }

        }
    }
}

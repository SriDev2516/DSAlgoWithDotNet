using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeImplementation
{
    public class BinarySearchTree
    {
        public List<int> ulist;
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
        public List<int> InOrderTraverseIteration(Node root)
        {
            List<int> list = new List<int>();
            Stack<Node> st = new Stack<Node>();

            while(true)
            {
                if (root != null)
                {
                    st.Push(root);
                    root = root.left;
                }
                else
                {
                    if (st.Count == 0) return list;

                    root = st.Pop();
                    list.Add(root.data);
                    root = root.right;
                }
            }

            
        }
        public List<int> InorderTraversalWithRecursion(Node root)
        {
            ulist = new List<int>();
            if (root == null) return ulist;

            InOrderTraverse(root);
            return ulist;
        }
        internal List<int> PostOrderTraversalWithRecursion(Node root)
        {
            ulist = new List<int>();
            if (root == null)
            {
                return ulist;
            }

            PostOrderTraverse(root);

            return ulist;
        }
        private void PostOrderTraverse(Node root)
        {
            if (root == null)
            {
                return;
            }

            PostOrderTraverse(root.left);
            PostOrderTraverse(root.right);
            ulist.Add(root.data);
        }
        public List<int> PreOrderTraversalWithIteration(Node root)
        {
            List<int> ans = new List<int>();
            Stack<Node> st = new Stack<Node>();

            if (root == null) return ans;

            st.Push(root);
            while(st.Count != 0)
            {
                root = st.Pop();
                ans.Add(root.data);

                if(root.right != null)
                {
                    st.Push(root.right);
                }

                if (root.left != null)
                {
                    st.Push(root.left);
                }
            }

            return ans;
        }
        public List<int> PreOrderTraversalWithRecrusion(Node root)
        {
            ulist = new List<int>();

            PreOrderTraverse(root);
            return ulist;

        }
        public List<int> PostOrderTraversalWithIteration(Node root)
        {
            List<int> list = new List<int>();
            if (root == null) return list;
            Stack<Node> st1 = new Stack<Node>();
            Stack<Node> st2 = new Stack<Node>();

            st1.Push(root);
            while (st1.Count != 0)
            {
                root = st1.Pop();
                st2.Push(root);
                if (root.left != null) st1.Push(root.left);
                if (root.right != null) st1.Push(root.right);
            }

            while(st2.Count != 0)
            {
                list.Add(st2.Pop().data);
            }

            return list;
        }
        private void PreOrderTraverse(Node root)
        {
            if (root == null) return;

            ulist.Add(root.data);
            PreOrderTraverse(root.left);
            PreOrderTraverse(root.right);
        }
        private void InOrderTraverse(Node root)
        {
            if (root == null) return;

            InOrderTraverse(root.left);
            ulist.Add(root.data);
            InOrderTraverse(root.right);
        }
    }
}

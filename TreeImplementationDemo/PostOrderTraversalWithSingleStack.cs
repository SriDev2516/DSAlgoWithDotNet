using BinaryTreeImplementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace TreeImplementationDemo
{
    class PostOrderTraversalWithSingleStack
    {
        public void PostOrderTraverse(Node root)
        {
            //Algorithm

            // curr = root
            // while curr != null || !st.IsEmpty()
            // if
            // curr != null -> st.Push(curr) -> curr = root.left;
            // else 
            // temp = st.Pop().right;
            // if(temp == null)
            //   temp = st.Pop();
            //   list.Add(temp)
            // while !st.empty && st.Pop().right == temp
            // temp = st.Pop
            // post.Add(temp)
            // else
            // curr = temp 

            Node curr = root;
            Stack<Node> st = new Stack<Node>();
            List<int> list = new List<int>();

            while (curr != null || st.Count != 0)
            {
                if(curr != null)
                {
                    st.Push(curr);
                    curr = curr.left;
                }
                else
                {
                    Node temp = st.Pop();
                   
                    if(temp.right == null)
                    {
                        list.Add(temp.data);
                        while (st.Count != 0 && temp == st.Pop().right)
                        {
                            temp = st.Pop();
                            list.Add(temp.data);
                        }
                    }
                    else
                    {
                        curr = temp.right;
                    }
                }
            }

        }
    }
}

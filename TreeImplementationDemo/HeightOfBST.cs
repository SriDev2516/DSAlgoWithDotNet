using BinaryTreeImplementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace TreeImplementationDemo
{
    public class HeightOfBST
    {
        public int FindHeight(Node root)
        {
            if (root == null) return 0;

            int lh = FindHeight(root.left);
            int rh = FindHeight(root.left);

            int value =  1+Math.Max(lh, rh);

            return value;


        }
    }
}

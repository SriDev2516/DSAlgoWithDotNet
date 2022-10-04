using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class BinarySearchTreeInsertion: BinarySearchTree
    {
        public BinarySearchTreeInsertion(): base()
        {

        }

        public Node InsertIntoBinaryTree(Node currentNode, int value)
        {
           
            if(currentNode == null)
            {
                currentNode = new Node(value);
                return currentNode;
            }
            else
            
                if(value < currentNode.value)
                {
                    currentNode.left = InsertIntoBinaryTree(currentNode.left, value);
                }
            else if(value > currentNode.value)
            {
                currentNode.right = InsertIntoBinaryTree(currentNode.right, value);
            }

            return currentNode;
        }



    }
}

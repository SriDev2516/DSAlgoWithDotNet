using BinaryTreeImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeImplementationDemo
{
    class ZigZagTraversal
    {
        public IList<IList<int>> ZigzagLevelOrder(Node root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Queue<Node> queue = new Queue<Node>();
            if (root == null) return result;
            queue.Enqueue(root);
            int levelCount = 1;
            while (queue.Count != 0)
            {

                var count = queue.Count;
                IList<int> temp = new List<int>();
                for (int i = 0; i < count; i++)
                {
                    if (queue.Peek().left != null) queue.Enqueue(queue.Peek().left);
                    if (queue.Peek().right != null) queue.Enqueue(queue.Peek().right);
                    temp.Add(queue.Dequeue().data);

                    if (levelCount % 2 == 0)
                    {
                        temp.Reverse();
                    }

                }

                
                levelCount++;
            }

            return result;
        }
    }
}

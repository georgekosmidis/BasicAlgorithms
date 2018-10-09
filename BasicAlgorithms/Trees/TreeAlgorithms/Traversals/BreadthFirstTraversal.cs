using BasicAlgorithms.Trees.TreeAlgorithms.Interfaces;
using BasicAlgorithms.Trees.TreeAlgorithms.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicAlgorithms.Trees.TreeAlgorithms.Traversals
{
    public class BreadthFirstTraversal : ITraversals
    {

        public BinaryTree UnTraverse(List<int> data)
        {
            throw new NotImplementedException();
        }

        public List<int> Traverse(BinaryTree tree)
        {
            var data = new List<int>();
            var queue = new Queue<BinaryTree>();
            queue.Enqueue(tree);
            while (queue.Count() > 0)
            {
                var node = queue.Dequeue();
                data.Add(node.Data);
                if (node.LeftNode != null)
                    queue.Enqueue(node.LeftNode);
                if (node.RightNode != null)
                    queue.Enqueue(node.RightNode);
            }

            return data;
        }
    }
}

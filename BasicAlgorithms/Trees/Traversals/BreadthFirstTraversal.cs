using BasicAlgorithms.Trees.Interfaces;
using BasicAlgorithms.Trees.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicAlgorithms.Trees.Traversals
{
    public class BreadthFirstTraversal : ITraversals
    {

        public BinaryTree UnTraverse(List<int> data)
        {
            throw new NotImplementedException();
            //var queue = new List<BinaryTree>();
            //queue.Insert(0, tree);
            //while (queue.Count > 0)
            //{
            //    var node = queue.Last();
            //    queue.Remove(node);

            //    if (node.LeftNode != null)
            //        queue.Insert(0, node.LeftNode);
            //    else
            //    {
            //        node.LeftNode = new BinaryTree();
            //        return node.LeftNode;
            //    }

            //    if (node.RightNode != null)
            //        queue.Insert(0, node.RightNode);
            //    else
            //    {
            //        node.RightNode = new BinaryTree();
            //        return node.RightNode;
            //    }

            //}
            //return new BinaryTree();
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

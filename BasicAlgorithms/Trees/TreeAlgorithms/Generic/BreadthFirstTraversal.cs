using BasicAlgorithms.Trees.Interfaces;
using BasicAlgorithms.Trees.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicAlgorithms.Trees.TreeAlgorithms.Generic
{
    public class BreadthFirstTraversal : ITraversals
    {

        public BinaryTree FirstFree(BinaryTree tree)
        {
            var queue = new List<BinaryTree>();
            queue.Insert(0, tree);
            while (queue.Count > 0)
            {
                var node = queue.Last();
                queue.Remove(node);

                if (node.LeftNode != null)
                    queue.Insert(0, node.LeftNode);
                else
                {
                    node.LeftNode = new BinaryTree();
                    return node.LeftNode;
                }

                if (node.RightNode != null)
                    queue.Insert(0, node.RightNode);
                else
                {
                    node.RightNode = new BinaryTree();
                    return node.RightNode;
                }

            }
            return new BinaryTree();
        }

        public List<int> Traverse(BinaryTree tree)
        {
            return new List<int>();
        }
    }
}

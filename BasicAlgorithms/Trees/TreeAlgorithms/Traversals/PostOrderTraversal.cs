using BasicAlgorithms.Trees.TreeAlgorithms.Interfaces;
using BasicAlgorithms.Trees.TreeAlgorithms.Models;
using System;
using System.Collections.Generic;

namespace BasicAlgorithms.Trees.TreeAlgorithms.Traversals
{
    public class PostOrderTraversal : ITraversals
    {

        public BinaryTree UnTraverse(List<int> data)
        {
            throw new NotImplementedException();
        }

        public List<int> Traverse(BinaryTree tree)
        {
            var list = new List<int>();

            if (tree.LeftNode != null)
                list.AddRange(Traverse(tree.LeftNode));

            if (tree.RightNode != null)
                list.AddRange(Traverse(tree.RightNode));

            list.Add(tree.Data);

            return list;
        }
    }
}

using BasicAlgorithms.Trees.TreeAlgorithms.Interfaces;
using BasicAlgorithms.Trees.TreeAlgorithms.Models;
using System;
using System.Collections.Generic;

namespace BasicAlgorithms.Trees.TreeAlgorithms.Traversals
{
    public class InOrderTraversal : ITraversals
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

            list.Add(tree.Data);

            if (tree.RightNode != null)
                list.AddRange(Traverse(tree.RightNode));

            return list;
        }
    }
}

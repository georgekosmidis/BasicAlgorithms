using BasicAlgorithms.Trees.TreeAlgorithms.Models;
using BasicAlgorithms.Trees.TreeAlgorithms.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicAlgorithms.Trees.TreeAlgorithms.Traversals
{
    public class PreOrderTraversal : ITraversals
    {

        public BinaryTree UnTraverse(List<int> data)
        {
            throw new NotImplementedException();
        }

        public List<int> Traverse(BinaryTree tree)
        {
            var list = new List<int>();

            list.Add(tree.Data);

            if (tree.LeftNode != null)
               list.AddRange( Traverse(tree.LeftNode));

            if (tree.RightNode != null)
                list.AddRange(Traverse(tree.RightNode));

            return list;
        }
    }
}

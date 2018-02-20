using BasicAlgorithms.Trees.Interfaces;
using BasicAlgorithms.Trees.TreeAlgorithms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicAlgorithms.Trees.TreeAlgorithms.TypedTrees
{
    public class BinarySearchTree : ITree
    {

        public BinarySearchTree()
        {
        }

        public BinaryTreeResults<BinaryTree> CreateTree(List<int> data)
        {
            var length = data.Count;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            data.Sort();
            var tree = _CreateTree(data, 0, length - 1);
            watch.Stop();

            return new BinaryTreeResults<BinaryTree>()
            {
                Result = tree,
                Ticks = watch.ElapsedTicks
            };
        }

        public BinaryTreeResults<BinaryTree> Search(BinaryTree tree, int item)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var result = _Search(tree, item);
            watch.Stop();

            return new BinaryTreeResults<BinaryTree>()
            {
                Result = result,
                Ticks = watch.ElapsedTicks
            };
        }

        public BinaryTreeResults<BinaryTree> Insert(BinaryTree tree, int item)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            tree = _Insert(tree, item);
            watch.Stop();

            return new BinaryTreeResults<BinaryTree>()
            {
                Result = tree,
                Ticks = watch.ElapsedTicks
            };
        }

        private BinaryTree _CreateTree(List<int> data, int start, int end)
        {
            if (start > end)
                return null;

            var middle = (start + end) / 2;

            return new BinaryTree()
            {
                Data = data[middle],
                LeftNode = _CreateTree(data, start, middle - 1),
                RightNode = _CreateTree(data, middle + 1, end)
            };
        }

        private BinaryTree _Search(BinaryTree tree, int item)
        {
            if (tree == null)
                return null;

            if (tree.Data == item)
                return tree;
            else
            {
                if (item > tree.Data)
                    return _Search(tree.RightNode, item);
                else
                    return _Search(tree.LeftNode, item);
            }

        }

        private BinaryTree _Insert(BinaryTree tree, int item)
        {
            if (tree == null)
                return new BinaryTree() { Data = item };

            if (item < tree.Data)
                tree.LeftNode = _Insert(tree.LeftNode, item);
            else if (item > tree.Data)
                tree.RightNode = _Insert(tree.RightNode, item);

            return tree;
        }

        //private void _FixTree(BinaryTree tree)
        //{
        //    if (tree.LeftNode != null)
        //        _FixTree(tree.LeftNode);
        //    if (tree.RightNode != null)
        //        _FixTree(tree.RightNode);

        //    if (tree.LeftNode != null && tree.Data < tree.LeftNode.Data)
        //    {
        //        var tmp = tree.LeftNode.Data;
        //        tree.LeftNode.Data = tree.Data;
        //        tree.Data = tmp;
        //    }

        //    if (tree.RightNode != null && tree.Data < tree.RightNode.Data)
        //    {
        //        var tmp = tree.RightNode.Data;
        //        tree.RightNode.Data = tree.Data;
        //        tree.Data = tmp;
        //    }

        //}

    }
}

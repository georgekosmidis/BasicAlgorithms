using BasicAlgorithms.Trees.TreeAlgorithms.Interfaces;
using BasicAlgorithms.Trees.TreeAlgorithms.Models;
using System.Collections.Generic;

namespace BasicAlgorithms.Trees.TreeAlgorithms.TypedTrees;

public class BinarySearchTree : ITree
{

    public BinaryTreeResults<BinaryTree> CreateTree(List<int> data)
    {
        var length = data.Count;
        var watch = System.Diagnostics.Stopwatch.StartNew();
        data.Sort();
        var tree = HelperCreateTree(data, 0, length - 1);
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
        var result = HelperSearch(tree, item);
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
        tree = HelperInsert(tree, item);
        watch.Stop();

        return new BinaryTreeResults<BinaryTree>()
        {
            Result = tree,
            Ticks = watch.ElapsedTicks
        };
    }

    private BinaryTree HelperCreateTree(List<int> data, int start, int end)
    {
        if (start > end)
        {
            return null;
        }

        var middle = (start + end) / 2;

        return new BinaryTree()
        {
            Data = data[middle],
            LeftNode = HelperCreateTree(data, start, middle - 1),
            RightNode = HelperCreateTree(data, middle + 1, end)
        };
    }

    private BinaryTree HelperSearch(BinaryTree tree, int item)
    {
        if (tree == null)
        {
            return null;
        }

        if (tree.Data == item)
        {
            return tree;
        }
        else
        {
            if (item > tree.Data)
            {
                return HelperSearch(tree.RightNode, item);
            }
            else
            {
                return HelperSearch(tree.LeftNode, item);
            }
        }

    }

    private BinaryTree HelperInsert(BinaryTree tree, int item)
    {
        if (tree == null)
        {
            return new BinaryTree() { Data = item };
        }

        if (item < tree.Data)
        {
            tree.LeftNode = HelperInsert(tree.LeftNode, item);
        }
        else if (item > tree.Data)
        {
            tree.RightNode = HelperInsert(tree.RightNode, item);
        }

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

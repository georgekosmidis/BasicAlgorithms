using BasicAlgorithms.Trees.Interfaces;
using BasicAlgorithms.Trees.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicAlgorithms.Trees.TreeAlgorithms
{
    public class HeapTree : ITree
    {

        public HeapTree()
        {
        }

        public BinaryTreeResults<BinaryTree> Deserialize(List<int> data)
        {
            var length = data.Count;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            var tree = _Deserialize(data, length, 0);
            watch.Stop();

            return new BinaryTreeResults<BinaryTree>()
            {
                Result = tree,
                Ticks = watch.ElapsedTicks
            };
        }

        public BinaryTreeResults<List<int>> Serialize(BinaryTree tree)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var list = _Serialize(tree);
            watch.Stop();

            return new BinaryTreeResults<List<int>>()
            {
                Result = list,
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
            _Insert(tree, item);
            watch.Stop();

            return new BinaryTreeResults<BinaryTree>()
            {
                Result = tree,
                Ticks = watch.ElapsedTicks
            };
        }

        public BinaryTreeResults<BinaryTree> Delete(BinaryTree tree, int item)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            _Delete(tree, item);
            watch.Stop();

            return new BinaryTreeResults<BinaryTree>()
            {
                Result = tree,
                Ticks = watch.ElapsedTicks
            };
        }
        private void _Delete(BinaryTree tree, int item)
        {

            //find last item and disconnected from its parent
            BinaryTree deleteNode = new BinaryTree();
            var queue = new List<Tuple<BinaryTree, BinaryTree>>();
            queue.Insert(0, new Tuple<BinaryTree, BinaryTree>(null, tree));
            while (queue.Count > 0)
            {
                var lastItem = queue.Last();
                queue.Remove(lastItem);
                if (lastItem.Item2.Data == item)
                    deleteNode = lastItem.Item2;

                if (lastItem.Item2.LeftNode != null)
                    queue.Insert(0, new Tuple<BinaryTree, BinaryTree>(lastItem.Item2, lastItem.Item2.LeftNode));

                if (lastItem.Item2.RightNode != null)
                    queue.Insert(0, new Tuple<BinaryTree, BinaryTree>(lastItem.Item2, lastItem.Item2.RightNode));

                if (queue.Count == 0)
                {
                    if (lastItem.Item1.RightNode == null)
                        lastItem.Item1.LeftNode = null;
                    else
                        lastItem.Item1.RightNode = null;

                    deleteNode.Data = lastItem.Item2.Data;
                    _FixTree(deleteNode);
                }

            }            
        }


        private BinaryTree _Deserialize(List<int> data, int length, int largest)
        {
            //assume largest and get left and right that should be smaller
            var new_largest = largest;
            var left = 2 * largest + 1;//left branch of heap tree
            var right = 2 * largest + 2;//right branch of heap tree

            //if left is larger, get that as the new largest
            if (left < length && data[left] > data[new_largest])
                new_largest = left;

            //if right is larger, get that as the new largest
            if (right < length && data[right] > data[new_largest])
                new_largest = right;

            //if there is a change in largest swap
            // and recurse with the new largest
            if (new_largest != largest)
            {
                var tmp = data[largest];
                data[largest] = data[new_largest];
                data[new_largest] = tmp;
            }

            //return the tree
            return new BinaryTree()
            {
                Data = data[largest],
                LeftNode = (2 * largest + 1 < length) ? _Deserialize(data, length, 2 * largest + 1) : null,
                RightNode = (2 * largest + 2 < length) ? _Deserialize(data, length, 2 * largest + 2) : null
            };
        }

        private List<int> _Serialize(BinaryTree tree)
        {
            var list = new List<int>()
            {
                { tree.Data }
            };

            if (tree.LeftNode != null)
                list.AddRange(_Serialize(tree.LeftNode));
            if (tree.RightNode != null)
                list.AddRange(_Serialize(tree.RightNode));

            return list;
        }

        private BinaryTree _Search(BinaryTree tree, int item)
        {
            BinaryTree result = new BinaryTree();

            if (tree == null)
                return null;

            if (tree.Data == item)
                return tree;

            if (tree.LeftNode != null && item <= tree.LeftNode.Data)
                result = _Search(tree.LeftNode, item);
            if (tree.RightNode != null && item <= tree.RightNode.Data)
                result = _Search(tree.RightNode, item);

            return result;
        }

        private void _Insert(BinaryTree tree, int item)
        {
            var insertItem = item;
            if (item >= tree.Data)
            {
                insertItem = tree.Data;
                tree.Data = item;
            }

            if (tree.LeftNode == null)
                tree.LeftNode = new BinaryTree() { Data = insertItem };
            else if (tree.RightNode == null)
                tree.RightNode = new BinaryTree() { Data = insertItem };
            else
            {
                if (tree.LeftNode.Data <= insertItem)
                    _Insert(tree.LeftNode, insertItem);
                else
                    _Insert(tree.RightNode, insertItem);
            }

        }

        private void _FixTree(BinaryTree tree)
        {
            if (tree.LeftNode != null)
                _FixTree(tree.LeftNode);
            if (tree.RightNode != null)
                _FixTree(tree.RightNode);

            if (tree.LeftNode != null && tree.Data < tree.LeftNode.Data)
            {
                var tmp = tree.LeftNode.Data;
                tree.LeftNode.Data = tree.Data;
                tree.Data = tmp;
            }

            if (tree.RightNode != null && tree.Data < tree.RightNode.Data)
            {
                var tmp = tree.RightNode.Data;
                tree.RightNode.Data = tree.Data;
                tree.Data = tmp;
            }

        }



    }
}

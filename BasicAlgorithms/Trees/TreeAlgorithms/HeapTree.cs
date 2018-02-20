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
        ITraversals _breadthFirstTraversal;
        public HeapTree(ITraversals breadthFirstTraversal)
        {
            _breadthFirstTraversal = breadthFirstTraversal;
            //todo: guard, is this a breadth-first traversal?
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
            return new BinaryTreeResults<List<int>>()
            {
                Result = new List<int>(),
                Ticks = 0
            };
        }

        public BinaryTreeResults<int> Search(BinaryTree tree, int item)
        {
            return new BinaryTreeResults<int>()
            {
                Result = 0,
                Ticks = 0
            };
        }

        public BinaryTreeResults<BinaryTree> Insert(BinaryTree tree, int item)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            _Insert(tree, item);
            //var node = _breadthFirstTraversal.FirstFree(tree);
            //node.Data = item;
            //_FixTree(tree);

            watch.Stop();
            return new BinaryTreeResults<BinaryTree>()
            {
                Result = tree,
                Ticks = watch.ElapsedTicks
            };
        }

        private void _Insert(BinaryTree tree, int item)
        {
            if (item >= tree.Data)
            {
                var tmp = tree.Data;
                tree.Data = item;
                if (tree.LeftNode == null)
                    tree.LeftNode = new BinaryTree() { Data = tmp };
                else if (tree.RightNode == null)
                    tree.RightNode = new BinaryTree() { Data = tmp };
                else
                {
                    if (tree.LeftNode.Data <= item)
                        _Insert(tree.LeftNode, tmp);
                    else
                        _Insert(tree.RightNode, tmp);
                }
            }
            else
            {
                if (tree.LeftNode == null)
                    tree.LeftNode = new BinaryTree() { Data = item };
                else if (tree.RightNode == null)
                    tree.RightNode = new BinaryTree() { Data = item };
                else
                {
                    if (tree.LeftNode.Data <= item)
                        _Insert(tree.LeftNode, item);
                    else
                        _Insert(tree.RightNode, item);
                }
            }
        }


        public BinaryTreeResults<int> Delete(BinaryTree tree, int item)
        {
            return new BinaryTreeResults<int>()
            {
                Result = 0,
                Ticks = 0
            };
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
    }
}

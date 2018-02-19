using BasicAlgorithms.Trees.Interfaces;
using BasicAlgorithms.Trees.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithms.Trees.TreeAlgorithms
{
    public class HeapTree : ITree
    {


        public BinaryTreeResults<BinaryTree> Deserialize(List<int> data)
        {
            var length = data.Count;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            var tree = HeapifyToTree(data, length, 0);
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

        public BinaryTreeResults<int> Insert(BinaryTree tree, int item)
        {
            return new BinaryTreeResults<int>()
            {
                Result = 0,
                Ticks = 0
            };
        }

        public BinaryTreeResults<int> Delete(BinaryTree tree, int item)
        {
            return new BinaryTreeResults<int>()
            {
                Result = 0,
                Ticks = 0
            };
        }

        private BinaryTree HeapifyToTree(List<int> data, int length, int largest)
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
                LeftNode = (2 * largest + 1 < length) ? HeapifyToTree(data, length, 2 * largest + 1) : null,
                RightNode = (2 * largest + 2 < length) ? HeapifyToTree(data, length, 2 * largest + 2) : null
            };

        }
    }
}

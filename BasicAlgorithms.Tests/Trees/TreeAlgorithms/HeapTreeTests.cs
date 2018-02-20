using BasicAlgorithms.Trees;
using BasicAlgorithms.Trees.TreeAlgorithms;
using BasicAlgorithms.Trees.TreeAlgorithms.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithms.Tests.Trees.TreeAlgorithms
{
    [TestClass]
    public class HeapTreeTests
    {

        [TestMethod]
        public void HeapTree_Create()
        {
            var tree = new HeapTree(new BreadthFirstTraversal());

            var list = new List<int>() { 3, 6, 2, 4, 5, 1 };
            var result = tree.Deserialize(list).Result;

            Assert.AreEqual(6, result.Data);
            Assert.AreEqual(5, result.LeftNode.Data);
            Assert.AreEqual(4, result.LeftNode.LeftNode.Data);
            Assert.AreEqual(3, result.LeftNode.RightNode.Data);
            Assert.AreEqual(2, result.RightNode.Data);
            Assert.AreEqual(1, result.RightNode.LeftNode.Data);
        }

        [TestMethod]
        public void HeapTree_Create_SmallTest()
        {
            var tree = new HeapTree(new BreadthFirstTraversal());

            var list = new List<int>() { 2, 3, 1 };
            var result = tree.Deserialize(list).Result;

            Assert.AreEqual(3, result.Data);
            Assert.AreEqual(2, result.LeftNode.Data);
            Assert.AreEqual(1, result.RightNode.Data);
        }

        [TestMethod]
        public void HeapTree_Insert()
        {
            var heapTree = new HeapTree(new BreadthFirstTraversal());

            var list = new List<int>() { 2, 4, 3, 1 };
            var tree = heapTree.Deserialize(list).Result;

            Assert.AreEqual(4, tree.Data);
            Assert.AreEqual(2, tree.LeftNode.Data);
            Assert.AreEqual(1, tree.LeftNode.LeftNode.Data);
            Assert.AreEqual(3, tree.RightNode.Data);

            tree = heapTree.Insert(tree, 5).Result;
            Assert.AreEqual(5, tree.Data);
            Assert.AreEqual(4, tree.LeftNode.Data);
            Assert.AreEqual(1, tree.LeftNode.LeftNode.Data);
            Assert.AreEqual(2, tree.LeftNode.RightNode.Data);
            Assert.AreEqual(3, tree.RightNode.Data);

        }

        [TestMethod]
        public void HeapTree_Insert_Middle()
        {
            var heapTree = new HeapTree(new BreadthFirstTraversal());

            var list = new List<int>() { 2, 4, 6 };
            var tree = heapTree.Deserialize(list).Result;

            Assert.AreEqual(6, tree.Data);
            Assert.AreEqual(4, tree.LeftNode.Data);
            Assert.AreEqual(2, tree.RightNode.Data);

            tree = heapTree.Insert(tree, 5).Result;
            Assert.AreEqual(6, tree.Data);
            Assert.AreEqual(5, tree.LeftNode.Data);
            Assert.AreEqual(4, tree.LeftNode.LeftNode.Data);
            Assert.AreEqual(2, tree.RightNode.Data);

        }
    }
}

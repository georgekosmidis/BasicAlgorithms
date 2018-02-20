using BasicAlgorithms.Trees;
using BasicAlgorithms.Trees.TreeAlgorithms;
using BasicAlgorithms.Trees.TreeAlgorithms.TypedTrees;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithms.Tests.Trees.TreeAlgorithms
{
    [TestClass]
    public class BinarySearchTreeTests
    {

        [TestMethod]
        public void BinarySearchTree_Deserialize()
        {
            var tree = new BinarySearchTree();

            var list = new List<int>() { 1, 2, 3, 4, 5, 6 };
            var result = tree.CreateTree(list).Result;

            Assert.AreEqual(3, result.Data);
            Assert.AreEqual(1, result.LeftNode.Data);
            Assert.AreEqual(2, result.LeftNode.RightNode.Data);
            Assert.AreEqual(5, result.RightNode.Data);
            Assert.AreEqual(4, result.RightNode.LeftNode.Data);
            Assert.AreEqual(6, result.RightNode.RightNode.Data);
        }

        [TestMethod]
        public void BinarySearchTree_Deserialize_SmallTest()
        {
            var tree = new BinarySearchTree();

            var list = new List<int>() { 1, 2, 3 };
            var result = tree.CreateTree(list).Result;

            Assert.AreEqual(2, result.Data);
            Assert.AreEqual(1, result.LeftNode.Data);
            Assert.AreEqual(3, result.RightNode.Data);
        }

        [TestMethod]
        public void BinarySearchTree_Insert_AtTop()
        {
            var binarySearchTree = new BinarySearchTree();

            var list = new List<int>() { 2, 4, 3, 1 };
            var tree = binarySearchTree.CreateTree(list).Result;

            Assert.AreEqual(2, tree.Data);
            Assert.AreEqual(1, tree.LeftNode.Data);
            Assert.AreEqual(3, tree.RightNode.Data);
            Assert.AreEqual(4, tree.RightNode.RightNode.Data);

            tree = binarySearchTree.Insert(tree, 5).Result;
            Assert.AreEqual(2, tree.Data);
            Assert.AreEqual(1, tree.LeftNode.Data);
            Assert.AreEqual(3, tree.RightNode.Data);
            Assert.AreEqual(4, tree.RightNode.RightNode.Data);
            Assert.AreEqual(5, tree.RightNode.RightNode.RightNode.Data);
        }

        [TestMethod]
        public void BinarySearchTree_Insert_AtMiddle()
        {
            var binarySearchTree = new BinarySearchTree();

            var list = new List<int>() { 2, 4, 6 };
            var tree = binarySearchTree.CreateTree(list).Result;

            Assert.AreEqual(4, tree.Data);
            Assert.AreEqual(2, tree.LeftNode.Data);
            Assert.AreEqual(6, tree.RightNode.Data);

            tree = binarySearchTree.Insert(tree, 5).Result;
            Assert.AreEqual(4, tree.Data);
            Assert.AreEqual(2, tree.LeftNode.Data);
            Assert.AreEqual(6, tree.RightNode.Data);
            Assert.AreEqual(5, tree.RightNode.LeftNode.Data);
        }

        [TestMethod]
        public void BinarySearchTree_Search()
        {
            var binarySearchTree = new BinarySearchTree();

            var list = new List<int>() { 2, 4, 6 };
            var tree = binarySearchTree.CreateTree(list).Result;

            var item = binarySearchTree.Search(tree, 2).Result;
            Assert.AreEqual(2, item.Data);
        }

    }
}

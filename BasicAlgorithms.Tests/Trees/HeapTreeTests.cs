using BasicAlgorithms.Trees;
using BasicAlgorithms.Trees.TreeAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithms.Tests.Trees
{
    [TestClass]
    public class HeapTreeTests
    {

        [TestMethod]
        public void HeapTree_Create()
        {
            var tree = new HeapTree();

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
            var tree = new HeapTree();

            var list = new List<int>() { 2, 3, 1 };
            var result = tree.Deserialize(list).Result;

            Assert.AreEqual(3, result.Data);
            Assert.AreEqual(2, result.LeftNode.Data);
            Assert.AreEqual(1, result.RightNode.Data);
        }
    }
}

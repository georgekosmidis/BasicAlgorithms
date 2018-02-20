using BasicAlgorithms.Trees;
using BasicAlgorithms.Trees.Traversals;
using BasicAlgorithms.Trees.TreeAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithms.Tests.Trees.Traversals
{
    [TestClass]
    public class BreadthFirstTests
    {

       
        [TestMethod]
        public void BreadthFirst_Traversal()
        {
            var treeCreation = new BinarySearchTree();
            var list = new List<int>() { 2, 4, 3, 1 };
            var tree = treeCreation.CreateTree(list).Result;

            list = new BreadthFirstTraversal().Traverse(tree);

            Assert.AreEqual(2, list[0]);
            Assert.AreEqual(1, list[1]);
            Assert.AreEqual(3, list[2]);
            Assert.AreEqual(4, list[3]);
        }
    }
}

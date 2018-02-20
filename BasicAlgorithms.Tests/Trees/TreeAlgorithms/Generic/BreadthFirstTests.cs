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
    public class BreadthFirstTests
    {

       

        [TestMethod]
        public void BreadthFirst_FindFirstFree()
        {
            var heapTree = new HeapTree(new BreadthFirstTraversal());
            var list = new List<int>() { 2, 4, 3, 1 };
            var tree = heapTree.Deserialize(list).Result;
            Assert.IsNull(tree.LeftNode.RightNode);

            var traversal = new BreadthFirstTraversal();
            traversal.FirstFree(tree);
            Assert.IsNotNull(tree.LeftNode.RightNode);
        }
    }
}

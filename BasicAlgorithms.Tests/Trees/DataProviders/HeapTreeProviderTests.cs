using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicAlgorithms.Array.DataProviders;
using System;
using System.Collections.Generic;
using System.Text;
using BasicAlgorithms.Array.DataProviders.Providers;
using BasicAlgorithms.Trees;
using BasicAlgorithms.Trees.DataProviders.Providers;
using BasicAlgorithms.Trees.TreeAlgorithms;
using BasicAlgorithms.Trees.TreeAlgorithms.Generic;

namespace BasicAlgorithms.Tests.Trees.DataProviders
{
    [TestClass]
    public class HeapTreeProviderTests
    {
        [TestMethod]
        public void HeapTreeProvider_GetTree()
        {
            var data = new TreeProvider(
                            new HeapTree(
                                new BreadthFirstTraversal()
                            ),
                            10);

            Assert.AreEqual(1, data.MinValue);
            Assert.AreEqual(10, data.MaxValue);
            Assert.AreEqual(6, data.AvgValue);
            Assert.AreEqual(11, data.NotFoundValue);

            Assert.AreEqual(10, data.Tree.Data);
            Assert.AreEqual(9, data.Tree.LeftNode.Data);
            Assert.AreEqual(7, data.Tree.LeftNode.LeftNode.Data);
            Assert.AreEqual(6, data.Tree.LeftNode.RightNode.Data);
            Assert.AreEqual(8, data.Tree.RightNode.Data);
            Assert.AreEqual(5, data.Tree.RightNode.LeftNode.Data);
        }
    }
}

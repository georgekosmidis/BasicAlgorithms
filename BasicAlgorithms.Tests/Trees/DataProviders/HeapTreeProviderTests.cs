using BasicAlgorithms.Trees.DataProviders.Providers;
using BasicAlgorithms.Trees.TreeAlgorithms.TypedTrees;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicAlgorithms.Tests.Trees.DataProviders
{
    [TestClass]
    public class HeapTreeProviderTests
    {
        [TestMethod]
        public void HeapTreeProvider_GetTree()
        {
            var data = new TreeDataProvider(new HeapTree(), 10);

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

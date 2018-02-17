using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchAlgorithms.Algorithms;
using System.Collections.Generic;

namespace SearchAlgorithms.Tests
{
    [TestClass]
    public class LinearSearchTests
    {
        [TestMethod]
        public void LinearSearch_Find_FindFirst()
        {
            var search = new LinearSearch();

            var list = new List<int>() { 2, 4, 6 };
            var result = search.Find(list, 2);
            Assert.AreEqual(0, result.PositionFound);
        }

        [TestMethod]
        public void LinearSearch_Find_FindLast()
        {
            var search = new LinearSearch();

            var list = new List<int>() { 2, 4, 6 };
            var result = search.Find(list, 6);
            Assert.AreEqual(2, result.PositionFound);
        }

        [TestMethod]
        public void LinearSearch_Find_FindMiddle()
        {
            var search = new LinearSearch();

            var list = new List<int>() { 2, 4, 6 };
            var result = search.Find(list, 4);
            Assert.AreEqual(1, result.PositionFound);
        }

        [TestMethod]
        public void LinearSearch_Find_NoFind()
        {
            var search = new LinearSearch();

            var list = new List<int>() { 2, 4, 6 };
            var result = search.Find(list, 5);
            Assert.IsNull(result.PositionFound);
        }
    }
}

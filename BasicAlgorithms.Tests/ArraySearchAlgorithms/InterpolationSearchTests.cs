using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicAlgorithms.ArraySearchAlgorithms;
using System.Collections.Generic;

namespace BasicAlgorithms.Tests
{
    [TestClass]
    public class InterpolationSearchTests
    {
        [TestMethod]
        public void InterpolationSearch_Find_FindFirst()
        {
            var search = new InterpolationSearch();

            var list = new List<int>() { 2, 4, 6 };
            var result = search.Find(list, 2);
            Assert.AreEqual(0, result.PositionFound);
        }

        [TestMethod]
        public void InterpolationSearch_Find_FindLast()
        {
            var search = new InterpolationSearch();

            var list = new List<int>() { 2, 4, 6 };
            var result = search.Find(list, 6);
            Assert.AreEqual(2, result.PositionFound);

            list = new List<int>() { 2, 4, 6, 8 };
            result = search.Find(list, 8);
            Assert.AreEqual(3, result.PositionFound);
        }

        [TestMethod]
        public void InterpolationSearch_Find_FindMiddle()
        {
            var search = new InterpolationSearch();

            var list = new List<int>() { 2, 4, 6 };
            var result = search.Find(list, 4);
            Assert.AreEqual(1, result.PositionFound);

            list = new List<int>() { 2, 4, 6, 8 };
            result = search.Find(list, 6);
            Assert.AreEqual(2, result.PositionFound);
        }

        [TestMethod]
        public void InterpolationSearch_Find_NoFind()
        {
            var search = new InterpolationSearch();

            var list = new List<int>() { 2, 4, 6 };
            var result = search.Find(list, 5);
            Assert.IsNull(result.PositionFound);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchAlgorithms.DataProviders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SearchAlgorithms.Tests.DataProviders
{
    [TestClass]
    public class SortedProviderTests
    {
        [TestMethod]
        public void Sorted_GetSortedList()
        {
            var data = new SortedProvider(10);

            Assert.AreEqual(10, data.Data.Count);
            Assert.AreEqual(0, data.MinValue);
            Assert.AreEqual(27, data.MaxValue);
            Assert.AreEqual(14, data.AvgValue);
            Assert.AreEqual(28, data.NotFoundValue);
        }
    }
}

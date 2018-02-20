using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicAlgorithms.Array.DataProviders;
using System;
using System.Collections.Generic;
using System.Text;
using BasicAlgorithms.Array.DataProviders.Providers;

namespace BasicAlgorithms.Tests.Arrays.DataProviders
{
    [TestClass]
    public class ReverseSortedProviderTests
    {
        [TestMethod]
        public void ReverseSortedProvider_GetSortedList()
        {
            var data = new ReverseSortedProvider(10);

            Assert.AreEqual(data.Data[0], 10);
            Assert.AreEqual(10, data.Data.Count);
            Assert.AreEqual(1, data.MinValue);
            Assert.AreEqual(10, data.MaxValue);
            Assert.AreEqual(6, data.AvgValue);
            Assert.AreEqual(11, data.NotFoundValue);
        }
    }
}

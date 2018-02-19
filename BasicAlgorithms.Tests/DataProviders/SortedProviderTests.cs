using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicAlgorithms.Array.DataProviders;
using System;
using System.Collections.Generic;
using System.Text;
using BasicAlgorithms.Array.DataProviders.Providers;

namespace BasicAlgorithms.Tests.Array.DataProviders
{
    [TestClass]
    public class SortedProviderTests
    {
        [TestMethod]
        public void SortedProvider_GetSortedList()
        {
            var data = new SortedProvider(10);

            Assert.AreEqual(10, data.Data.Count);
            Assert.AreEqual(0, data.MinValue);
            Assert.AreEqual(2147483638, data.MaxValue);
            Assert.AreEqual(2147483642, data.AvgValue);
            Assert.AreEqual(2147483643, data.NotFoundValue);
        }
    }
}

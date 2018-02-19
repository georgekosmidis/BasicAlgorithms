using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicAlgorithms.Array.DataProviders;
using System;
using System.Collections.Generic;
using System.Text;
using BasicAlgorithms.Array.DataProviders.Providers;

namespace BasicAlgorithms.Tests.Array.DataProviders
{
    [TestClass]
    public class UnsortedProviderTests
    {
        [TestMethod]
        public void UnsortedProvider_GetSortedList()
        {
            var data = new UnsortedProvider(10);

            Assert.AreEqual(10, data.Data.Count);
            Assert.AreEqual(10, data.MinValue);
            Assert.AreEqual(94, data.MaxValue);
            Assert.AreEqual(64, data.AvgValue);
            Assert.AreEqual(95, data.NotFoundValue);
        }
    }
}

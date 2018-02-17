using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicAlgorithms.DataProviders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithms.Tests.DataProviders
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
            Assert.AreEqual(77, data.AvgValue);
            Assert.AreEqual(95, data.NotFoundValue);
        }
    }
}

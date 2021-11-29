using BasicAlgorithms.Arrays.DataProviders.Providers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicAlgorithms.Tests.Arrays.DataProviders
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

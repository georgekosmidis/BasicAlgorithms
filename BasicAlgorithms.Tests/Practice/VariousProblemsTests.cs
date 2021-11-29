using BasicAlgorithms.Practice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BasicAlgorithms.Tests.Practice
{
    [TestClass]
    public class VariousProblemsTests
    {

        [TestMethod]
        public void VariousProblems_LongestPalindrom()
        {
            string result;

            result = VariousProblems.LongestPalindrom("bb");
            Assert.AreEqual("bb", result);

            result = VariousProblems.LongestPalindrom("babad");
            Assert.AreEqual("aba", result);

            result = VariousProblems.LongestPalindrom("eabcb");
            Assert.AreEqual("bcb", result);

        }


        [TestMethod]
        public void VariousProblems_LeftRotateMatrix()
        {
            var rotated = VariousProblems.LeftRotateMatrix(2, 2, 3, new List<int> { 1, 2, 3, 4 });

            Assert.AreEqual(2, rotated[0]);
            Assert.AreEqual(1, rotated[1]);
            Assert.AreEqual(4, rotated[2]);
            Assert.AreEqual(3, rotated[3]);
        }


        [TestMethod]
        public void VariousProblems_PrimeNumberSets()
        {
            Assert.AreEqual(4, VariousProblems.PrimeNumberSets(6, 10));
            Assert.AreEqual(5, VariousProblems.PrimeNumberSets(10, 15));
        }


        [TestMethod]
        public void VariousProblems_FindCharacterBinary()
        {
            Assert.AreEqual(1, VariousProblems.FindCharacterBinary(5, 5, 3));
            Assert.AreEqual(1, VariousProblems.FindCharacterBinary(11, 6, 4));
        }


        [TestMethod]
        public void VariousProblems_MaximumTipCalculator()
        {
            var orders = new List<int> { 5, 3, 3 };
            var tipsA = new List<int> { 1, 2, 3, 4, 5 };
            var tipsB = new List<int> { 5, 4, 3, 2, 1 };
            Assert.AreEqual(21, VariousProblems.MaximumTipCalculator(orders, tipsA, tipsB));

            orders = new List<int> { 8, 4, 4 };
            tipsA = new List<int> { 1, 4, 3, 2, 7, 5, 9, 6 };
            tipsB = new List<int> { 1, 2, 3, 6, 5, 4, 9, 8 };
            Assert.AreEqual(43, VariousProblems.MaximumTipCalculator(orders, tipsA, tipsB));
        }

        [TestMethod]
        public void VariousProblems_ArrayContiguousIntegers()
        {
            var list = new List<int> { 5, 2, 3, 6, 4, 4, 6, 6 };
            Assert.IsTrue(VariousProblems.ArrayContiguousIntegers(list));//2,3,4,5,6

            list = new List<int> { 10, 14, 10, 12, 12, 13, 15 };
            Assert.IsFalse(VariousProblems.ArrayContiguousIntegers(list));//no continous numbers
        }

        [TestMethod]
        public void VariousProblems_OrderByAbsoluteOrder()
        {
            var list = new List<int> { 1, -3, 2, 3, 6, -1 };
            var result = VariousProblems.OrderByAbsoluteOrder(list);
            Assert.AreEqual(-1, result[0]);
            Assert.AreEqual(1, result[1]);
            Assert.AreEqual(-3, result[2]);
            Assert.AreEqual(3, result[3]);

            list = new List<int> { 4, 8, 9, -4, 1, -1, -8, -9 };
            result = VariousProblems.OrderByAbsoluteOrder(list);
            Assert.AreEqual(-1, result[0]);
            Assert.AreEqual(1, result[1]);
            Assert.AreEqual(-4, result[2]);
            Assert.AreEqual(4, result[3]);
            Assert.AreEqual(-8, result[4]);
            Assert.AreEqual(8, result[5]);
            Assert.AreEqual(-9, result[6]);
            Assert.AreEqual(9, result[7]);
        }
    }
}

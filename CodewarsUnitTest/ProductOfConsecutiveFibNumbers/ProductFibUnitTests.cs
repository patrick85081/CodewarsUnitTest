using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodewarsUnitTest.ProductOfConsecutiveFibNumbers
{
    [TestClass]
    public class ProductFibUnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            ulong[] expected = new ulong[] { 55, 89, 1 };
            ulong[] actual = ProdFib.ProductFib(4895);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            ulong[] expected = new ulong[] { 21, 34, 1 };
            ulong[] actual = ProdFib.ProductFib(714);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            ulong[] expected = new ulong[] { 34, 55, 0 };
            ulong[] actual = ProdFib.ProductFib(800);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodewarsUnitTest;

namespace CodewarsUnitTest.SortTheOdd
{
    [TestClass]
    public class SortArrayTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(
                new int[] { }, 
                Kata.SortArray(new int[] { }));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(
                new int[] { 1, 3, 2, 8, 5, 4 },
                Kata.SortArray(new int[] { 5, 3, 2, 8, 1, 4 }));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(
                new int[] { 1, 3, 5, 8, 0 }, 
                Kata.SortArray(new int[] { 5, 3, 1, 8, 0 }));
        }

        
    }
}

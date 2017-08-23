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
            int[] expected = new int[0];

            int[] actual = Kata.SortArray(new int[0]);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] expected = new int[] { 1, 3, 2, 8, 5, 4 };

            int[] actual = Kata.SortArray(new int[] { 5, 3, 2, 8, 1, 4 });

            CollectionAssert.AreEqual(expected, actual);
            
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] expected = new int[] { 1, 3, 5, 8, 0 };

            int[] actual = Kata.SortArray(new int[] { 5, 3, 1, 8, 0 });

            CollectionAssert.AreEqual(expected, actual);
        }

        
    }
}

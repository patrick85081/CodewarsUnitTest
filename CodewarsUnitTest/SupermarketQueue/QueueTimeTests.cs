﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodewarsUnitTest.SupermarketQueue
{
    [TestClass]
    public class QueueTimeTests
    {
        [TestMethod]
        public void QueueTimeTest_NoCustomer_QueueTime_is_0()
        {
            long expected = 0;

            long actual = Kata.QueueTime(new int[] { }, 1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void QueueTimeTest_Four_Customer_One_Clerk_QueueTime_is_Sum()
        {
            long expected = 10;

            long actual = Kata.QueueTime(new int[] { 1, 2, 3, 4 }, 1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void QueueTimeTest_Six_Customer_Two_Clerk()
        {
            long expected = 9;

            long actual = Kata.QueueTime(new int[] { 2, 2, 3, 3, 4, 4 }, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void QueueTimeTest_Five_Customer_Hundred_Clerk()
        {
            long expected = 5;

            long actual = Kata.QueueTime(new int[] { 1, 2, 3, 4, 5 }, 100);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ExtendedTest1()
        {
            long expected = 12;

            long actual = Kata.QueueTime(new int[] {5, 3, 4}, 1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ExtendedTest2()
        {
            long expected = 10;

            long actual = Kata.QueueTime(new int[] {10, 2, 3, 3}, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ExtendedTest3()
        {
            long expected = 12;

            long actual = Kata.QueueTime(new int[] {2, 3, 10}, 2);

            Assert.AreEqual(expected, actual);
        }
    }
}

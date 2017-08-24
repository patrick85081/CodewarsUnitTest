using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodewarsUnitTest.RGBToHexConversion
{
    [TestClass]
    public class RgbTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("FFFFFF", Kata.Rgb(255, 255, 255));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("FFFFFF", Kata.Rgb(255, 255, 300));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("000000", Kata.Rgb(0, 0, 0));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual("9400D3", Kata.Rgb(148, 0, 211));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual("9400D3", Kata.Rgb(148, -20, 211), "Handle negative numbers.");
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual("90C3D4", Kata.Rgb(144, 195, 212));
        }

        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual("D4350C", Kata.Rgb(212, 53, 12), "Consider single hex digit numbers.");
        }
    }
}

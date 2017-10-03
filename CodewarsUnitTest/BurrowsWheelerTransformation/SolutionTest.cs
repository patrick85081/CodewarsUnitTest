using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsUnitTest.BurrowsWheelerTransformation
{
    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        public void EncodingTest()
        {
            Assert.AreEqual("nnbbraaaa", Kata.Encode("bananabar").Item1);
            Assert.AreEqual(4, Kata.Encode("bananabar").Item2);
            Assert.AreEqual("e emnllbduuHB", Kata.Encode("Humble Bundle").Item1);
            Assert.AreEqual(2, Kata.Encode("Humble Bundle").Item2);
            Assert.AreEqual("ww MYeelllloo", Kata.Encode("Mellow Yellow").Item1);
            Assert.AreEqual(1, Kata.Encode("Mellow Yellow").Item2);
        }

        [TestMethod]
        public void DecodingTest()
        {
            Assert.AreEqual("bananabar", Kata.Decode("nnbbraaaa", 4));
            Assert.AreEqual("Humble Bundle", Kata.Decode("e emnllbduuHB", 2));
            Assert.AreEqual("Mellow Yellow", Kata.Decode("ww MYeelllloo", 1));
            Assert.AreEqual(new String('x', 20), Kata.Decode(new String('x', 20), 0));
        }

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual("", Kata.Encode("").Item1);

            Assert.AreEqual("", Kata.Decode("", -1));
        }
    }
}

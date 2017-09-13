using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsUnitTest.CatchingCarMileageNumbers
{
    [TestClass]
    public class IsInterestingTests
    {
        [TestMethod]
        public void BoaringNumberTest()
        {
            Assert.AreEqual(0, Kata.IsInteresting(3, new List<int>() {1337, 256}));
            Assert.AreEqual(0, Kata.IsInteresting(3236, new List<int>() { 1337, 256 }));
        }

        [TestMethod]
        public void NoNearingAweosePhrasesTest()
        {
            Assert.AreEqual(0, Kata.IsInteresting(11207, new List<int>() { }));
            Assert.AreEqual(0, Kata.IsInteresting(11208, new List<int>() { }));
            Assert.AreEqual(1, Kata.IsInteresting(11209, new List<int>() { }));
            Assert.AreEqual(1, Kata.IsInteresting(11210, new List<int>() { }));
            Assert.AreEqual(2, Kata.IsInteresting(11211, new List<int>() { }));
        }

        [TestMethod]
        public void NearingAwesomePhraseTest()
        {
            Assert.AreEqual(1, Kata.IsInteresting(1335, new List<int>() { 1337, 256 }));
            Assert.AreEqual(1, Kata.IsInteresting(1336, new List<int>() { 1337, 256 }));
            Assert.AreEqual(2, Kata.IsInteresting(1337, new List<int>() { 1337, 256 }));
        }

        [TestMethod]
        public void ShouldWorkTest()
        {
            Assert.AreEqual(0, Kata.IsInteresting(3, new List<int>() { 1337, 256 }));
            Assert.AreEqual(1, Kata.IsInteresting(1336, new List<int>() { 1337, 256 }));
            Assert.AreEqual(2, Kata.IsInteresting(1337, new List<int>() { 1337, 256 }));
            Assert.AreEqual(0, Kata.IsInteresting(11208, new List<int>() { 1337, 256 }));
            Assert.AreEqual(1, Kata.IsInteresting(11209, new List<int>() { 1337, 256 }));
            Assert.AreEqual(2, Kata.IsInteresting(11211, new List<int>() { 1337, 256 }));
        }

        [TestMethod]
        public void SequentialTest()
        {
            Assert.AreEqual(1, Kata.IsInteresting(1233, new List<int>() { 1337, 256 }));
            Assert.AreEqual(2, Kata.IsInteresting(1234, new List<int>() { 1337, 256 }));
            Assert.AreEqual(0, Kata.IsInteresting(1235, new List<int>() { 1337, 256 }));

            Assert.AreEqual(1, Kata.IsInteresting(67889, new List<int>() { 1337, 256 }));
            Assert.AreEqual(2, Kata.IsInteresting(67890, new List<int>() { 1337, 256 }));
            Assert.AreEqual(0, Kata.IsInteresting(67891, new List<int>() { 1337, 256 }));

            Assert.AreEqual(1, Kata.IsInteresting(4320, new List<int>() { 1337, 256 }));
            Assert.AreEqual(2, Kata.IsInteresting(4321, new List<int>() { 1337, 256 }));
            Assert.AreEqual(0, Kata.IsInteresting(4322, new List<int>() { 1337, 256 }));
        }

        [TestMethod]
        public void AdvanceTest()
        {
            Assert.AreEqual(1, Kata.IsInteresting(109, new List<int>() { 1337, 256 }));
        }
    }
}

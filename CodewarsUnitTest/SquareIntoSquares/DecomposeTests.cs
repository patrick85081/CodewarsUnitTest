using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsUnitTest.SquareIntoSquares
{
    [TestClass]
    public class DecomposeTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Decompose d = new Decompose();
            long n = 11;
            Assert.AreEqual("1 2 4 10", d.decompose(n));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Decompose d = new Decompose();
            long n = 12;
            Assert.AreEqual("1 2 3 7 9", d.decompose(n));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Decompose d = new Decompose();
            long n = 625;
            Assert.AreEqual("2 5 8 34 624", d.decompose(n));
        }
    }
}

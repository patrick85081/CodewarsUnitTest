﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsUnitTest.DecodeTheMorseCodeForReal
{
    [TestClass]
    public class MorseCodeDecoderRealTest
    {
        [TestMethod]
        public void TestSample()
        {
            //.... . -.--   .--- ..- -.. . 
            var expected = "HEY JUDE";

            var actual = MorseCodeDecoder.decodeMorse(
                MorseCodeDecoder.decodeBitsAdvanced(
                    "0000000011011010011100000110000001111110100111110011111100000000000111011111111011111011111000000101100011111100000111110011101100000100000"));

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEmptyMessage1()
        {
            //
            var expected = "";

            var actual = MorseCodeDecoder.decodeMorse(
                MorseCodeDecoder.decodeBitsAdvanced(
                    "0"));

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEmptyMessage2()
        {
            //
            var expected = "";

            var actual = MorseCodeDecoder.decodeMorse(
                MorseCodeDecoder.decodeBitsAdvanced(
                    ""));

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestExampleFromDescription()
        {
            //
            var expected = "HEY JUDE";

            var actual = MorseCodeDecoder.decodeMorse(
                MorseCodeDecoder.decodeBitsAdvanced(
                    "0000000011011010011100000110000001111110100111110011111100000000000111011111111011111011111000000101100011111100000111110011101100000100000"));

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestExtraZeros()
        {
            //
            var expected = "E";

            var actual = MorseCodeDecoder.decodeMorse(
                MorseCodeDecoder.decodeBitsAdvanced(
                    "01110"));

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLongMessage1()
        {
            //
            var expected = "HEY JUDE";

            var actual = MorseCodeDecoder.decodeMorse(
                MorseCodeDecoder.decodeBitsAdvanced(
                    "1100110011001100000011000000111111001100111111001111110000000000000011001111110011111100111111000000110011001111110000001111110011001100000011"));

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLongMessage2()
        {
            //- .... .   --.- ..- .. -.-. -.-   -... .-. --- .--   .--- ..- -- .--. ...   --- ...- . .-.   - .... .   .-.. .- --.. -.--   -.. --- --.
            var expected = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";

            var actual = MorseCodeDecoder.decodeMorse(
                MorseCodeDecoder.decodeBitsAdvanced(
                    "00000000000111111100000011010001110111000000001110000000000000000001111111011111100001101111100000111100111100011111100000001011100000011111110010001111100110000011111100101111100000000000000111111100001111010110000011000111110010000011111110001111110011111110000010001111110001111111100000001111111101110000000000000010110000111111110111100000111110111110011111110000000011111001011011111000000000000111011111011111011111000000010001001111100000111110111111110000001110011111100011111010000001100001001000000000000000000111111110011111011111100000010001001000011111000000100000000101111101000000000000011111100000011110100001001100000000001110000000000000001101111101111000100000100001111111110000000001111110011111100011101100000111111000011011111000111111000000000000000001111110000100110000011111101111111011111111100000001111110001111100001000000000000000000000000000000000000000000000000000000000000"));

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultipleBitsPerDot()
        {
            //
            var expected = "E";

            var actual = MorseCodeDecoder.decodeMorse(
                MorseCodeDecoder.decodeBitsAdvanced(
                    "111"));

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestShortMessages1()
        {
            //
            var expected = "E";

            var actual = MorseCodeDecoder.decodeMorse(
                MorseCodeDecoder.decodeBitsAdvanced(
                    "111"));

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestShortMessages2()
        {
            //
            var expected = "";

            var actual = MorseCodeDecoder.decodeMorse(
                MorseCodeDecoder.decodeBitsAdvanced(
                    "000000000000000000000000000000000000000000"));

            Assert.AreEqual(expected, actual);
        }

        //[TestMethod]
        //public void TestShortMessages3()
        //{
        //    //
        //    var expected = "EE";

        //    var actual = MorseCodeDecoder.decodeMorse(
        //        MorseCodeDecoder.decodeBitsAdvanced(
        //            "101"));

        //    Assert.AreEqual(expected, actual);
        //}

        //[TestMethod]
        //public void TestShortMessages4()
        //{
        //    //
        //    var expected = "EE";

        //    var actual = MorseCodeDecoder.decodeMorse(
        //        MorseCodeDecoder.decodeBitsAdvanced(
        //            "1001"));

        //    Assert.AreEqual(expected, actual);
        //}
    }
}

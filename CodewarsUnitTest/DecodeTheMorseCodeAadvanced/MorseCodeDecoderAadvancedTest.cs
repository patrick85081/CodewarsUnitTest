using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodewarsUnitTest.DecodeTheMorseCodeAadvanced
{
    [TestClass]
    public class MorseCodeDecoderAadvancedTest
    {
        [TestMethod]
        public void TestExampleFromDescription()
        {
            //.... . -.--   .--- ..- -.. . 
            var expected = "HEY JUDE";

            var actual =
                MorseCodeDecoder.DecodeMorse(
                    MorseCodeDecoder.DecodeBits(
                        "1100110011001100000011000000111111001100111111001111110000000000000011001111110011111100111111000000110011001111110000001111110011001100000011"));
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BasicBitsDecoding1()
        {
            //.
            var expected = "E";

            var actual =
                MorseCodeDecoder.DecodeMorse(
                    MorseCodeDecoder.DecodeBits(
                        "1"));
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void BasicBitsDecoding2()
        {
            //..
            var expected = "I";

            var actual =
                MorseCodeDecoder.DecodeMorse(
                    MorseCodeDecoder.DecodeBits(
                        "101"));
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void BasicBitsDecoding3()
        {
            //. .
            var expected = "EE";

            var actual =
                MorseCodeDecoder.DecodeMorse(
                    MorseCodeDecoder.DecodeBits(
                        "10001"));
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void BasicBitsDecoding4()
        {
            //.-
            var expected = "A";

            var actual =
                MorseCodeDecoder.DecodeMorse(
                    MorseCodeDecoder.DecodeBits(
                        "10111"));
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void BasicBitsDecoding5()
        {
            //--
            var expected = "M";

            var actual =
                MorseCodeDecoder.DecodeMorse(
                    MorseCodeDecoder.DecodeBits(
                        "1110111"));
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MultipleBitsPerDotHandling1()
        {
            //.
            var expected = "E";

            var actual =
                MorseCodeDecoder.DecodeMorse(
                    MorseCodeDecoder.DecodeBits(
                        "111"));
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MultipleBitsPerDotHandling2()
        {
            //.
            var expected = "E";

            var actual =
                MorseCodeDecoder.DecodeMorse(
                    MorseCodeDecoder.DecodeBits(
                        "1111111"));
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MultipleBitsPerDotHandling3()
        {
            //..
            var expected = "I";

            var actual =
                MorseCodeDecoder.DecodeMorse(
                    MorseCodeDecoder.DecodeBits(
                        "110011"));
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MultipleBitsPerDotHandling4()
        {
            //..
            var expected = "I";

            var actual =
                MorseCodeDecoder.DecodeMorse(
                    MorseCodeDecoder.DecodeBits(
                        "111110000011111"));
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MultipleBitsPerDotHandling5()
        {
            //--
            var expected = "M";

            var actual =
                MorseCodeDecoder.DecodeMorse(
                    MorseCodeDecoder.DecodeBits(
                        "11111100111111"));
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ExtraZerosHandling1()
        {
            //.
            var expected = "E";

            var actual =
                MorseCodeDecoder.DecodeMorse(
                    MorseCodeDecoder.DecodeBits(
                        "01110"));
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ExtraZerosHandling2()
        {
            //.
            var expected = "E";

            var actual =
                MorseCodeDecoder.DecodeMorse(
                    MorseCodeDecoder.DecodeBits(
                        "000000011100000"));
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ExtraZerosHandling3()
        {
            //- .... .   --.- ..- .. -.-. -.-   -... .-. --- .-- -.   ..-. --- -..-   .--- ..- -- .--. ...   --- ...- . .-.   - .... .   .-.. .- --.. -.--   -.. --- --.  
            var expected = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG.";

            var actual =
                MorseCodeDecoder.DecodeMorse(
                    MorseCodeDecoder.DecodeBits(
                        "00011100010101010001000000011101110101110001010111000101000111010111010001110101110000000111010101000101110100011101110111000101110111000111010000000101011101000111011101110001110101011100000001011101110111000101011100011101110001011101110100010101000000011101110111000101010111000100010111010000000111000101010100010000000101110101000101110001110111010100011101011101110000000111010100011101110111000111011101000101110101110101110"));
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ExtraZerosHandling4()
        {
            //- .... .   --.- ..- .. -.-. -.-   -... .-. --- .-- -.   ..-. --- -..-   .--- ..- -- .--. ...   --- ...- . .-.   - .... .   .-.. .- --.. -.--   -.. --- --.  
            var expected = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG.";

            var actual =
                MorseCodeDecoder.DecodeMorse(
                    MorseCodeDecoder.DecodeBits(
                        "11111111111111100000000000000011111000001111100000111110000011111000000000000000111110000000000000000000000000000000000011111111111111100000111111111111111000001111100000111111111111111000000000000000111110000011111000001111111111111110000000000000001111100000111110000000000000001111111111111110000011111000001111111111111110000011111000000000000000111111111111111000001111100000111111111111111000000000000000000000000000000000001111111111111110000011111000001111100000111110000000000000001111100000111111111111111000001111100000000000000011111111111111100000111111111111111000001111111111111110000000000000001111100000111111111111111000001111111111111110000000000000001111111111111110000011111000000000000000000000000000000000001111100000111110000011111111111111100000111110000000000000001111111111111110000011111111111111100000111111111111111000000000000000111111111111111000001111100000111110000011111111111111100000000000000000000000000000000000111110000011111111111111100000111111111111111000001111111111111110000000000000001111100000111110000011111111111111100000000000000011111111111111100000111111111111111000000000000000111110000011111111111111100000111111111111111000001111100000000000000011111000001111100000111110000000000000000000000000000000000011111111111111100000111111111111111000001111111111111110000000000000001111100000111110000011111000001111111111111110000000000000001111100000000000000011111000001111111111111110000011111000000000000000000000000000000000001111111111111110000000000000001111100000111110000011111000001111100000000000000011111000000000000000000000000000000000001111100000111111111111111000001111100000111110000000000000001111100000111111111111111000000000000000111111111111111000001111111111111110000011111000001111100000000000000011111111111111100000111110000011111111111111100000111111111111111000000000000000000000000000000000001111111111111110000011111000001111100000000000000011111111111111100000111111111111111000001111111111111110000000000000001111111111111110000011111111111111100000111110000000000000001111100000111111111111111000001111100000111111111111111000001111100000111111111111111"));
            Assert.AreEqual(expected, actual);
        }
    }
}

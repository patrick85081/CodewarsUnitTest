using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodewarsUnitTest.DecodeTheMorseCodeAadvanced
{
    [TestClass]
    public class MorseCodeDecoderTest
    {
        [TestMethod]
        public void TestExampleFromDescription()
        {
            var expected = "HEY JUDE";

            var actual =
                MorseCodeDecoder.DecodeMorse(
                    MorseCodeDecoder.DecodeBits(
                        "1100110011001100000011000000111111001100111111001111110000000000000011001111110011111100111111000000110011001111110000001111110011001100000011"));
            Assert.AreEqual(expected, actual);
        }
    }
}

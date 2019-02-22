using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumOfDigits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits.Tests
{
    [TestClass()]
    public class AddDigitsToSingleDigitTests
    {
        [TestMethod()]
        public void SumOfDigitsTest_1Digit()
        {
            Assert.AreEqual(9, AddDigitsToSingleDigit.SumOfDigits(9));
        }
        [TestMethod()]
        public void SumOfDigitsTest_2Digit()
        {
            Assert.AreEqual(7, AddDigitsToSingleDigit.SumOfDigits(34));
        }
        [TestMethod()]
        public void SumOfDigitsTest_3Digit()
        {
            Assert.AreEqual(3, AddDigitsToSingleDigit.SumOfDigits(543));
        }
        [TestMethod()]
        public void SumOfDigitsTest_4Digit()
        {
            Assert.AreEqual(3, AddDigitsToSingleDigit.SumOfDigits(9876));
        }
        [TestMethod()]
        public void SumOfDigitsTest_5Digit()
        {
            Assert.AreEqual(9, AddDigitsToSingleDigit.SumOfDigits(99999));
        }
        [TestMethod()]
        public void SumOfDigitsTest_9Digit()
        {
            Assert.AreEqual(7, AddDigitsToSingleDigit.SumOfDigits(403221112));
        }
    }
}
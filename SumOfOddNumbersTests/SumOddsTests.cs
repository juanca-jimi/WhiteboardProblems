using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumOfOddNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfOddNumbers.Tests
{
    [TestClass()]
    public class SumOddsTests
    {
        [TestMethod()]
        public void sumOddsTest_neg3()
        {
            Assert.AreEqual(0, SumOdds.sumOfOdds(-3));
        }
        [TestMethod()]
        public void sumOddsTest_4()
        {
            Assert.AreEqual(4, SumOdds.sumOfOdds(4));
        }
        [TestMethod()]
        public void sumOddsTest_0()
        {
            Assert.AreEqual(0, SumOdds.sumOfOdds(0));
        }
        [TestMethod()]
        public void sumOddsTest_5()
        {
            Assert.AreEqual(9, SumOdds.sumOfOdds(5));
        }
        [TestMethod()]
        public void sumOddsTest_1()
        {
            Assert.AreEqual(1 , SumOdds.sumOfOdds(1));
        }
    }
}
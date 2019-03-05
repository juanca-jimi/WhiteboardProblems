using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckIfLeapYear;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfLeapYear.Tests
{
    [TestClass()]
    public class IsLeapYearTests
    {
        [TestMethod()]
        public void isLeapYearTest_False()
        {
            Assert.AreEqual(false, IsLeapYear.isLeapYear(1999));
        }
        [TestMethod()]
        public void isLeapYearTest_False1()
        {
            Assert.AreEqual(false, IsLeapYear.isLeapYear(2003));
        }
        [TestMethod()]
        public void isLeapYearTest_True()
        {
            Assert.AreEqual(true, IsLeapYear.isLeapYear(2004));
        }
        [TestMethod()]
        public void isLeapYearTest_True1()
        {
            Assert.AreEqual(true, IsLeapYear.isLeapYear(1992));
        }
    }
}
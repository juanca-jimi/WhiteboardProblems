using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumOfPrimes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfPrimes.Tests
{
    [TestClass()]
    public class AddPrimesTests
    {
        [TestMethod()]
        public void SumOfPrimesTest_7()
        {
            Assert.AreEqual(17, AddPrimes.SumOfPrimes(7));
        }
        [TestMethod()]
        public void SumOfPrimesTest_0()
        {
            Assert.AreEqual(0, AddPrimes.SumOfPrimes(0));
        }
        [TestMethod()]
        public void SumOfPrimesTest_1()
        {
            Assert.AreEqual(0, AddPrimes.SumOfPrimes(1));
        }
        [TestMethod()]
        public void SumOfPrimesTest_2()
        {
            Assert.AreEqual(2, AddPrimes.SumOfPrimes(2));
        }
        [TestMethod()]
        public void SumOfPrimesTest()
        {
            Assert.AreEqual(10, AddPrimes.SumOfPrimes(6));
        }





        [TestMethod()]
        public void IsPrimeTest_7()
        {
            Assert.AreEqual(true, AddPrimes.IsPrime(7));
        }
        [TestMethod()]
        public void IsPrimeTest_13()
        {
            Assert.AreEqual(true, AddPrimes.IsPrime(13));
        }
        [TestMethod()]
        public void IsPrimeTest_1()
        {
            Assert.AreEqual(false, AddPrimes.IsPrime(1));
        }
        [TestMethod()]
        public void IsPrimeTest_0()
        {
            Assert.AreEqual(false, AddPrimes.IsPrime(0));
        }
        [TestMethod()]
        public void IsPrimeTest_14()
        {
            Assert.AreEqual(false, AddPrimes.IsPrime(14));
        }
        [TestMethod()]
        public void IsPrimeTest_18()
        {
            Assert.AreEqual(false, AddPrimes.IsPrime(18));
        }
        [TestMethod()]
        public void IsPrimeTest_2()
        {
            Assert.AreEqual(true, AddPrimes.IsPrime(2));
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderName;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderName.Tests
{
    [TestClass()]
    public class OrderInputStringTests
    {
        [TestMethod()]
        public void orderNameTest_Garrett()
        {
            Assert.AreEqual("aegrrtt", OrderInputString.orderName("Garrett"));
        }
        [TestMethod()]
        public void orderNameTest_GARRett()
        {
            Assert.AreEqual("aegrrtt", OrderInputString.orderName("GARRett"));
        }
        [TestMethod()]
        public void orderNameTest_kilo()
        {
            Assert.AreEqual("iklo", OrderInputString.orderName("kilo"));
        }
        [TestMethod()]
        public void orderNameTest_pizZZAAA()
        {
            Assert.AreEqual("aaaipzzz", OrderInputString.orderName("pizZZAAA"));
        }
        [TestMethod()]
        public void orderNameTest_Idiom()
        {
            Assert.AreEqual("diimo", OrderInputString.orderName("Idiom"));
        }
    }
}
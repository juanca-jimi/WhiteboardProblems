using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReversingAString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// New comment.
namespace ReversingAString.Tests
{
    [TestClass()]
    public class ReverseStringTests
    {
        [TestMethod()]
        public void revStringTest_taco()
        {
            Assert.AreEqual("taco", ReverseString.revString("ocat"));
        }
        [TestMethod()]
        public void revStringTest_burrito()
        {
            Assert.AreEqual("burrito", ReverseString.revString("otirrub"));
        }
        [TestMethod()]
        public void revStringTest_hungry()
        {
            Assert.AreEqual("!yrgnuh", ReverseString.revString("hungry!"));
        }
        [TestMethod()]
        public void revStringTest_yesno()
        {
            Assert.AreEqual("sey on", ReverseString.revString("no yes"));
        }
        [TestMethod()]
        public void revStringTest_Isreal()
        {
            Assert.AreEqual("efil/laer siht-si", ReverseString.revString("is-this real/life"));
        }
    }
}
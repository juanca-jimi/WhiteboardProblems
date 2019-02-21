using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReversingArrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversingArrays.Tests
{
    [TestClass()]
    public class ReversingAnIntArrTests
    {
        [TestMethod()]
        public void revTest_4Digits()
        {
            int[] test = { 43, 2, 1, 7 };
            int[] answer = { 7, 1, 2, 43 };
            Assert.AreEqual(answer, ReversingAnIntArr.rev(test));
        }
        [TestMethod()]
        public void revTest_5Digits()
        {
            int[] test = { 43, 2, 1, 7, 98 };
            int[] answer = { 98,7,1,2,43 };
            Assert.AreEqual(answer, ReversingAnIntArr.rev(test));
        }
        [TestMethod()]
        public void revTest_1Digits()
        {
            int[] test = { 6 };
            int[] Answer = { 6 };
            Assert.AreEqual(Answer, ReversingAnIntArr.rev(test));
        }
        [TestMethod()]
        public void revTest_9Digits()
        {
            int[] test = { 43, 2, 1, 7,12,43,21,76,9 };
            int[] answer = { 9,76,21,43,12,7,1,2,43};
            Assert.AreEqual(answer, ReversingAnIntArr.rev(test));
        }
    }
}
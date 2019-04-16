using Microsoft.VisualStudio.TestTools.UnitTesting;
using minimumIntInArray;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimumIntInArray.Tests
{
    [TestClass()]
    public class MinIntTests
    {
        [TestMethod()]
        public void getMininumIntTest_2()
        {
            int[] test = { 7,3,2,4,65 };
            Assert.AreEqual(2, MinInt.getMininumInt(test));
        }
        [TestMethod()]
        public void getMininumIntTest_29()
        {
            int[] test = { 9997, 3876, 29, 476, 65 };
            Assert.AreEqual(29, MinInt.getMininumInt(test));
        }
        [TestMethod()]
        public void getMininumIntTest_0()
        {
            int[] test = { 7, 3, 2, 4, 65, 0 };
            Assert.AreEqual(0, MinInt.getMininumInt(test));
        }
        [TestMethod()]
        public void getMininumIntTest_neg7()
        {
            int[] test = { -7, 234563, 26565, 0, 65 };
            Assert.AreEqual(-7, MinInt.getMininumInt(test));
        }
        [TestMethod()]
        public void getMininumIntTest_neg65()
        {
            int[] test = { 7, 3, 2, 4, -65 };
            Assert.AreEqual(-65, MinInt.getMininumInt(test));
        }
        [TestMethod()]
        public void getMininumIntTest_65()
        {
            int[] test = { 72030, 1223, 04042, 465, 65 };
            Assert.AreEqual(65, MinInt.getMininumInt(test));
        }
    }
}
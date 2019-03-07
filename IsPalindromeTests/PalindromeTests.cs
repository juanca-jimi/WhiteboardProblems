using Microsoft.VisualStudio.TestTools.UnitTesting;
using IsPalindrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPalindrome.Tests
{
    [TestClass()]
    public class PalindromeTests
    {
        [TestMethod()]
        public void isAlphaNumericCharTest_true1()
        {
            Assert.AreEqual(true, Palindrome.isAlphaNumericChar('j'));
        }
        [TestMethod()]
        public void isAlphaNumericCharTest_true2()
        {
            Assert.AreEqual(true, Palindrome.isAlphaNumericChar('5'));
        }
        [TestMethod()]
        public void isAlphaNumericCharTest_false1()
        {
            Assert.AreEqual(false, Palindrome.isAlphaNumericChar('='));
        }
        [TestMethod()]
        public void isAlphaNumericCharTest_false2()
        {
            Assert.AreEqual(false, Palindrome.isAlphaNumericChar('?'));
        }
        //[TestMethod()]
        //public void isPalindromeTest_true1()
        //{
        //    Assert.AreEqual(true, Palindrome.isPalindrome("honeyenoh"));
        //}
        //[TestMethod()]
        //public void isPalindromeTest_true2()
        //{
        //    Assert.AreEqual(true, Palindrome.isPalindrome("RAce____[][!@##$Car"));
        //}
        [TestMethod()]
        public void isPalindromeTest_false1()
        {
            Assert.AreEqual(false, Palindrome.isPalindrome("Firetruck"));
        }
        [TestMethod()]
        public void isPalindromeTest_false2()
        {
            Assert.AreEqual(false, Palindrome.isPalindrome("racketBall[][][]"));
        }
    }
}
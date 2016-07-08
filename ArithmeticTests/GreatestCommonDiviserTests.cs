using System;
using Arithmetic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArithmeticTests
{
    [TestClass]
    public class GreatestCommonDiviserTests
    {
        [TestMethod]
        public void reflexive()
        {
            Assert.AreEqual(1, NumberTheory.gcd(1,1));
            Assert.AreEqual(2, NumberTheory.gcd(2, 2));
            Assert.AreEqual(1, NumberTheory.gcd(-1, -1));
        }

        [TestMethod]
        public void relativelyPrime()
        {
            Assert.AreEqual(1, NumberTheory.gcd(2, 3));
            Assert.AreEqual(1, NumberTheory.gcd(4, 7));
            Assert.AreEqual(1, NumberTheory.gcd(-2, -3));
        }

        [TestMethod]
        public void oneIsMultipleOfTheOther()
        {
            Assert.AreEqual(3, NumberTheory.gcd(3, 9));
            Assert.AreEqual(5, NumberTheory.gcd(5, 30));
        }

        [TestMethod]
        public void commonFactor()
        {
            Assert.AreEqual(2, NumberTheory.gcd(6, 8));
            Assert.AreEqual(7, NumberTheory.gcd(49, 315));
            Assert.AreEqual(4, NumberTheory.gcd(-24, -28));
        }

        [TestMethod]
        public void negatives()
        {
            Assert.AreEqual(4, NumberTheory.gcd(-24, 28));
            Assert.AreEqual(4, NumberTheory.gcd(24, -28));
        }

        [TestMethod]
        public void zero()
        {
            Assert.AreEqual(1, NumberTheory.gcd(1, 0));
            Assert.AreEqual(5, NumberTheory.gcd(0, 5));
            Assert.AreEqual(0, NumberTheory.gcd(0, 0));
        }
    }
}

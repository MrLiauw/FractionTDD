using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Arithmetic.Tests
{
    [TestClass()]
    public class FractionTests
    {
        [TestMethod()]
        public void ZeroPlusZero()
        {
            Assert.AreEqual(new Fraction(0), new Fraction(0).plus(new Fraction(0)));
        }

        [TestMethod()]
        public void nonZeroPlusZero()
        {
            Assert.AreEqual(new Fraction(3), new Fraction(3).plus(new Fraction(0)));
        }

        [TestMethod()]
        public void ZeroPlusNonZero()
        {
            Assert.AreEqual(new Fraction(3), new Fraction(0).plus(new Fraction(3)));
        }

        [TestMethod()]
        public void nonNegativeNonZeroOperands()
        {
            Assert.AreEqual(new Fraction(7), new Fraction(3).plus(new Fraction(4)));
        }

        [TestMethod()]
        public void negativeInputAndNegativeOutput()
        {
            Assert.AreEqual(new Fraction(-2), new Fraction(-3).plus(new Fraction(1)));
        }

        [TestMethod()]
        public void nonTrivialButCommonDenominator()
        {
            Assert.AreEqual(new Fraction(3,5), new Fraction(1, 5).plus(new Fraction(2, 5)));
        }

        [TestMethod()]
        public void differentDenominatorWithoutReducing()
        {
            Assert.AreEqual(new Fraction(5, 6), new Fraction(1, 2).plus(new Fraction(1, 3)));
        }

        [TestMethod()]
        public void reduceResultToWholeNumber()
        {
            Assert.AreEqual(new Fraction(1), new Fraction(1, 3).plus(new Fraction(2, 3)));
        }
    }
}

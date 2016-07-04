using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Arithmetic.Tests
{
    [TestClass()]
    public class FractionTests
    {
        [TestMethod()]
        public void ZeroPlusZero()
        {
            Fraction sum = new Fraction(0).plus(new Fraction(0));
            Assert.AreEqual(0, sum.toIntegerValue());
        }

        [TestMethod()]
        public void nonZeroPlusZero()
        {
            Fraction sum = new Fraction(3).plus(new Fraction(0));
            Assert.AreEqual(3, sum.toIntegerValue());
        }

        [TestMethod()]
        public void ZeroPlusNonZero()
        {
            Fraction sum = new Fraction(0).plus(new Fraction(3));
            Assert.AreEqual(3, sum.toIntegerValue());
        }

        [TestMethod()]
        public void nonNegativeNonZeroOperands()
        {
            Fraction sum = new Fraction(3).plus(new Fraction(4));
            Assert.AreEqual(7, sum.toIntegerValue());
        }

        [TestMethod()]
        public void negativeInputAndNegativeOutput()
        {
            Fraction sum = new Fraction(-3).plus(new Fraction(1));
            Assert.AreEqual(-2, sum.toIntegerValue());
        }
    }
}

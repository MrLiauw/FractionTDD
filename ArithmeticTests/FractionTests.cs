using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Arithmetic.Tests
{
    [TestClass()]
    public class FractionTests
    {
        [TestMethod()]
        public void ZeroPlusZero()
        {
            Assert.AreEqual(0, new Fraction(0).plus(new Fraction(0)).toIntegerValue());
        }

        [TestMethod()]
        public void nonZeroPlusZero()
        {
            Assert.AreEqual(3, new Fraction(3).plus(new Fraction(0)).toIntegerValue());
        }

        [TestMethod()]
        public void ZeroPlusNonZero()
        {
            Assert.AreEqual(3, new Fraction(0).plus(new Fraction(3)).toIntegerValue());
        }

        [TestMethod()]
        public void nonNegativeNonZeroOperands()
        {
            Assert.AreEqual(7, new Fraction(3).plus(new Fraction(4)).toIntegerValue());
        }

        [TestMethod()]
        public void negativeInputAndNegativeOutput()
        {
            Assert.AreEqual(-2, new Fraction(-3).plus(new Fraction(1)).toIntegerValue());
        }
    }
}

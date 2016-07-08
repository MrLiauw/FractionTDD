using Arithmetic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArithmeticTests
{
    [TestClass]
    public class FractionEqualsTests
    {
        [TestMethod]
        public void sameNumeratorAndSameDenominator()
        {
            Assert.AreEqual(new Fraction(3,5), new Fraction(3,5) );
        }

        [TestMethod]
        public void differentNumerator()
        {
            Assert.AreNotEqual(new Fraction(3, 5),new Fraction(4, 5));
        }

        [TestMethod]
        public void differentDenominator()
        {
            Assert.AreNotEqual(new Fraction(3, 7), new Fraction(3, 5));
        }

        [TestMethod]
        public void wholeNumberEqualsSameFraction()
        {
            Assert.AreEqual(new Fraction(3, 1), new Fraction(3));
        }

        [TestMethod]
        public void wholeNumberNotEqualofDifferentWholeNumber()
        {
            Assert.AreNotEqual(new Fraction(3), new Fraction(6));
        }
    }
}

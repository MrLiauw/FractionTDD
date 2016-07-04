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
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArithmeticTests
{
    [TestClass]
    public class GreatestCommonDiviserTests
    {
        [TestMethod]
        public void reflexive()
        {
            Assert.AreEqual(1, gcd(1,1));
            Assert.AreEqual(2, gcd(2, 2));
            Assert.AreEqual(-1, gcd(-1, -1));
        }

        [TestMethod]
        public void relativelyPrime()
        {
            Assert.AreEqual(1, gcd(2, 3));
            Assert.AreEqual(1, gcd(4, 7));
            Assert.AreEqual(-1, gcd(-2, -3));
        }

        [TestMethod]
        public void oneIsMultipleOfTheOther()
        {
            Assert.AreEqual(3, gcd(3, 9));
            Assert.AreEqual(5, gcd(5, 30));
        }

        [TestMethod]
        public void commonFactor()
        {
            Assert.AreEqual(2, gcd(6, 8));
            Assert.AreEqual(7, gcd(49, 315));
            Assert.AreEqual(-4, gcd(-24, -28));
        }

        [TestMethod]
        public void negatives()
        {
            Assert.AreEqual(4, gcd(-24, 28));
            Assert.AreEqual(-4, gcd(24, -28));
        }

        private int gcd(int a, int b)
        {
            while (b != 0)
            {
                int t = b;
                b = a%b;
                a = t;
            }
            return a;
        }
    }
}

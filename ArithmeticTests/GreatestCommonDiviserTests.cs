using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArithmeticTests
{
    [TestClass]
    public class GreatestCommonDiviserTests
    {
        [TestMethod]
        public void oneAndOne()
        {
            Assert.AreEqual(1, gcd(1,1));
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

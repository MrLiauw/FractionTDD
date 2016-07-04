using System;

namespace Arithmetic
{
    public class Fraction
    {
        private int integerValue;

        public Fraction(int integerValue)
        {
            this.integerValue = integerValue;
        }

        public Fraction plus(Fraction that)
        {
            return that;
        }

        public int toIntegerValue()
        {
            return integerValue;
        }
    }
}

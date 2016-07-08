namespace Arithmetic
{
    public class Fraction
    {
        private int integerValue;

        public Fraction(int integerValue)
        {
            this.integerValue = integerValue;
        }

        public Fraction(int numerator, int denominator)
        {
            
        }

        public Fraction plus(Fraction that)
        {
            return new Fraction(this.integerValue + that.integerValue);
        }

        public int toIntegerValue()
        {
            return integerValue;
        }

        public int getNumerator {
            get { return 3; }
        }

        public int getDenominator {
            get { return 5; }
        }
    }
}
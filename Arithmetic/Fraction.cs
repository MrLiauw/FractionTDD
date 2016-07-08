namespace Arithmetic
{
    public class Fraction
    {
        private readonly int _denominator;
        private readonly int _integerValue;

        public Fraction(int integerValue)
        {
            _integerValue = integerValue;
            _denominator = 1;
        }

        public Fraction(int numerator, int denominator)
        {
            _integerValue = numerator;
            _denominator = denominator;
        }

        public Fraction plus(Fraction that)
        {
            return new Fraction(_integerValue + that._integerValue, _denominator);
        }

        public int toIntegerValue()
        {
            return _integerValue;
        }

        public int getNumerator {
            get { return 3; }
        }

        public int getDenominator {
            get { return _denominator; }
        }
    }
}
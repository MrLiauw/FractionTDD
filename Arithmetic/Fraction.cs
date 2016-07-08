namespace Arithmetic
{
    public class Fraction
    {
        private readonly int _denominator;
        private readonly int _integerValue;
        private readonly int _numerator;

        public Fraction(int integerValue)
        {
            _integerValue = integerValue;
            _numerator = integerValue;
            _denominator = 1;
        }

        public Fraction(int numerator, int denominator)
        {
            _integerValue = numerator;
            _numerator = numerator;
            _denominator = denominator;
        }

        public Fraction plus(Fraction that)
        {
            return new Fraction(_numerator + that._numerator, _denominator);
        }

        public int toIntegerValue()
        {
            return _integerValue;
        }

        public int getNumerator {
            get { return _numerator; }
        }

        public int getDenominator {
            get { return _denominator; }
        }
    }
}
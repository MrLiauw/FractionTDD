namespace Arithmetic
{
    public class Fraction
    {
        private readonly int _denominator;
        private readonly int _numerator;

        public Fraction(int numerator, int denominator = 1)
        {
            int signOfDenominator = denominator < 0 ? -1 : 1;
            int gcd = NumberTheory.gcd(numerator, denominator) * signOfDenominator;
            _numerator = numerator / gcd;
            _denominator = denominator / gcd;
        }

        public Fraction plus(Fraction that)
        {
            return new Fraction(_numerator * that._denominator + _denominator * that._numerator,
                _denominator * that._denominator);
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}", _numerator, _denominator);
        }

        public override bool Equals(object other)
        {
            if (other is Fraction)
            {
                Fraction that = (Fraction)other;
                return _numerator == that._numerator &&
                       _denominator == that._denominator;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return _numerator * 19 + _denominator;
        }
    }
}
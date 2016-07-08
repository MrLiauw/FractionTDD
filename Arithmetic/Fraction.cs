namespace Arithmetic
{
    public class Fraction
    {
        private readonly int _denominator;
        private readonly int _numerator;

        public Fraction(int numerator, int denominator = 1)
        {
            _numerator = numerator;
            _denominator = denominator;
        }

        public Fraction plus(Fraction that)
        {
            return new Fraction(_numerator + that._numerator, _denominator);
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}", _numerator, _denominator);
        }

        public override bool Equals(object other)
        {
            if (other is Fraction)
            {
                Fraction that = (Fraction) other;
                return _numerator == that._numerator &&
                       _denominator == that._denominator;
            }
            return false;
        }
    }
}
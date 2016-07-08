﻿namespace Arithmetic
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

        public int toIntegerValue()
        {
            return _numerator;
        }

        public int getNumerator {
            get { return _numerator; }
        }

        public int getDenominator {
            get { return _denominator; }
        }
    }
}
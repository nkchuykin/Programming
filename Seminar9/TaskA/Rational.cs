using System;

public class Rational
{

    int numerator;
    int denomenator;

    private Rational(int n, int d)
    {
        numerator = n;
        denomenator = d;
    }

    public static Rational operator+(Rational a, Rational b)
    {
        throw new NotImplementedException();
    }

    public static Rational operator -(Rational a, Rational b)
    {
        throw new NotImplementedException();
    }

    public static Rational operator *(Rational a, Rational b)
    {
        throw new NotImplementedException();
    }

    public static Rational operator /(Rational a, Rational b)
    {
        throw new NotImplementedException();
    }

    public static Rational Parse(string input)
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        throw new NotImplementedException();
    }

}


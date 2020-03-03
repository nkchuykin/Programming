using System;

public struct Vector
{
    private double x;
    private double y;

    public double X
    {
        get { return x; }
    }

    public double Y
    {
        get { return y; }
    }

    public Vector(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public static Vector operator +(Vector a, Vector b)
    {
        throw new NotImplementedException();
    }

    public static Vector operator -(Vector a, Vector b)
    {
        throw new NotImplementedException();
    }

    public static double operator *(Vector a, Vector b)
    {
        throw new NotImplementedException();
    }

    public static Vector operator *(double number, Vector v)
    {
        throw new NotImplementedException();
    }

    public double GetLength()
    {
        throw new NotImplementedException();
    }

    public double GetAngleCos(Vector a)
    {
        throw new NotImplementedException();
    }

    public double GetVectorMultiplication(Vector a)
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        throw new NotImplementedException();
    }

    private static bool CheckLength(int dataLength, int currentLength)
    {
        throw new NotImplementedException();

    }

    private static double[] GetCoordinates(int dataLength)
    {
        throw new NotImplementedException();
    }

    public static void ReadVectors(out Vector vectorA, out Vector vectorB)
    {
        throw new NotImplementedException();
    }

    public static void ReadVectorAndNumber(out Vector vector, out double number)
    {
        throw new NotImplementedException();
    }

    public static Vector ReadVector()
    {
        throw new NotImplementedException();
    }
}

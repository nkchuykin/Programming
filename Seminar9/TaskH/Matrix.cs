using System;

public class Matrix
{

    int[,] matrix;

    public Matrix(int n, int m)
    {
        matrix = new int[n, m];
    }

    public void ReadMatrix()
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            string[] line = Console.ReadLine().Split(' ');
            for (int j = 0; j < line.Length; j++)
                matrix[i, j] = int.Parse(line[j]);
        }
    }

    public override string ToString()
    {
        string line = "";
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                line += matrix[i, j] + " ";
            line += "\n";
        }
        return line;
    }

    public static Matrix operator+(Matrix a, Matrix b)
    {
        throw new NotImplementedException();
    }

    public static Matrix operator -(Matrix a, Matrix b)
    {
        throw new NotImplementedException();
    }

    public static Matrix operator*(Matrix a, Matrix b)
    {
        throw new NotImplementedException();
    }

    public static Matrix operator~(Matrix a)
    {
        throw new NotImplementedException();
    }

    public static int operator!(Matrix a)
    {
        throw new NotImplementedException();
    }

    public static Matrix operator^(Matrix a, int n)
    {
        throw new NotImplementedException();
    }
}


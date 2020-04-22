using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] params1 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Matrix A = new Matrix(params1[0], params1[1]);
        A.ReadMatrix();
        int[] params2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Matrix B = new Matrix(params2[0], params2[1]);
        B.ReadMatrix();
        int n = int.Parse(Console.ReadLine());
        try
        {
            Console.WriteLine(A + B);
        }
        catch(ArithmeticException e)
        {
            Console.WriteLine(e.Message);
        }
        try
        {
            Console.WriteLine(A - B);
        }
        catch (ArithmeticException e)
        {
            Console.WriteLine(e.Message);
        }
        try
        {
            Console.WriteLine(A * B);
        }
        catch (ArithmeticException e)
        {
            Console.WriteLine(e.Message);
        }
        try
        {
            Console.WriteLine(~A);
        }
        catch (ArithmeticException e)
        {
            Console.WriteLine(e.Message);
        }
        try
        {
            Console.WriteLine(A ^ n);
        }
        catch (ArithmeticException e)
        {
            Console.WriteLine(e.Message);
        }
        try
        {
            Console.WriteLine(!A);
        }
        catch (ArithmeticException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
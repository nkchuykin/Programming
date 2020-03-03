using System;

internal class Program
{
    public static void Main(string[] args)
    {
        var operation = string.Empty;
        Vector a, b;

        while (true)
        {
            operation = Console.ReadLine();
            switch (operation)
            {
                case "+":
                    Vector.ReadVectors(out a, out b);
                    Console.WriteLine(a + b);
                    break;
                case "-":
                    Vector.ReadVectors(out a, out b);
                    Console.WriteLine(a - b);
                    break;
                case "*":
                    Vector.ReadVectors(out a, out b);
                    Console.WriteLine(string.Format("{0:0.###}", a * b));
                    break;
                case "*n":
                    double number;
                    Vector.ReadVectorAndNumber(out a, out number);
                    Console.WriteLine(number * a);
                    break;
                case "x":
                    Vector.ReadVectors(out a, out b);
                    Console.WriteLine(string.Format("{0:0.###}", a.GetVectorMultiplication(b)));
                    break;
                case "||":
                    a = Vector.ReadVector();
                    Console.WriteLine(string.Format("{0:0.###}", a.GetLength()));
                    break;
                case "<":
                    Vector.ReadVectors(out a, out b);
                    Console.WriteLine(string.Format("{0:0.###}", a.GetAngleCos(b)));
                    break;
                default:
                    return;
            }
        }
    }
}

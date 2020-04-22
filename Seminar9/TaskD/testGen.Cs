using System;
using System.IO;

internal class Program
{
    const int firstTest = 1; // because boundary cases should be tests by HANDWRITEN tests
    const int lastTest = 10;
    const string path = "../../tests/";
    private const string answerExstension = ".a";

    static void Main(string[] args)
    {

        Random rnd = new Random(124334652); //For test generation similarity

        for (int testNum = firstTest; testNum <= lastTest; testNum++)
        {
            using (StreamWriter input = new StreamWriter(path + testNum.ToString("D2")))
            using (StreamWriter output = new StreamWriter(path + testNum.ToString("D2") + answerExstension))
            {
                // Copy your program below this line
                // When you get input from Console generate random value send it to input stream writer
                // When you programm generate output send it to output instead of Console
                // Don't forget clear state
                
                int x = rnd.Next(1,999);
                input.WriteLine(x);
                int y = rnd.Next(1, 999);
                input.WriteLine(y);
                output.WriteLine(x.Max(y));
                output.WriteLine(x.ToString().Max(y.ToString()));
       

            }
        }


    }
    //public static void Main(string[] args)
    //{
    //    int x = int.Parse(Console.ReadLine());
    //    int y = int.Parse(Console.ReadLine());
    //    Console.WriteLine(x.Max(y));
    //    Console.WriteLine(x.ToString().Max(y.ToString()));
    //}
}
using System;

class MainClass
{

    static Range range = new Range();

    private static string ArrToStr(int[] arr)
    {
        string line = "";
        foreach (int i in arr)
            line += i + " ";
        return line;
    }

    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            try
            {
                int[] p = Array.ConvertAll(Console.ReadLine().Split(' '), str => int.Parse(str));
                switch (p.Length)
                {
                    case 1:
                        Console.WriteLine(ArrToStr(range[p[0]]));
                        break;

                    case 2:
                        Console.WriteLine(ArrToStr(range[p[0], p[1]]));
                        break;

                    case 3:
                        Console.WriteLine(ArrToStr(range[p[0], p[1], p[2]]));
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetType());
            }
        }
    }

}


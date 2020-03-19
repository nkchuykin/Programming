using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        BinFileReader bfr = new BinFileReader("input.txt");
        Console.WriteLine(bfr.GetDifference());
    }
}


using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

class Program
{
    static void Main(string[] args)
    {
        JSONReader jsonreader = new JSONReader("input.txt");
        Console.WriteLine(jsonreader.TheSickestStreet);
    }
}


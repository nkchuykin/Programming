using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Requests db = new Requests("../../words.txt");
        foreach (string word in db.Request(Console.ReadLine()))
            Console.Write(word);
    }
}

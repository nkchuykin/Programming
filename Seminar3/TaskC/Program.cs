using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Requests db = new Requests("../../numbers.txt");
        int[] answer = db.Request(Console.ReadLine());
        foreach (int num in answer)
            Console.Write(num + " ");
    }
}


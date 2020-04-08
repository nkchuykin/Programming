using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

class Program
{
    public static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        List<string> querrys = new List<string>();
        for (int i = 0; i < count; i++)
        {
            querrys.Add(Console.ReadLine());
        }
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.Load("catalog.xml");

        try
        {
            Methods.ProcessInput(xmlDocument, querrys).ForEach(Console.WriteLine);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
       
    }
}
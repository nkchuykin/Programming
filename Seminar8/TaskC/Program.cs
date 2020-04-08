using System;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using System.Collections.Generic;

internal class Program
{
    public static void Main(string[] args)
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Tree>));
        using (FileStream fs = new FileStream("trees.xml", FileMode.Open, FileAccess.Read))    
        {
            List<Tree> trees = (List<Tree>)xmlSerializer.Deserialize(fs);
            var maxTree = trees.Max();
            var allMax = trees.FindAll(t => t.CompareTo(maxTree) == 0);
            allMax.ForEach(Console.WriteLine);
        }   

    }
    
}
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader streamReader = new StreamReader("input.txt"))
        using (StreamWriter streamWriter = new StreamWriter("output.csv"))
        {
            ConverterTabToCSV.Convert(streamReader, streamWriter);
        }
    }
}


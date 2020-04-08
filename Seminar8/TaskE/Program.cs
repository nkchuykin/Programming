using System;

internal class Program
{
    private static void ProcessRequest<T>(Func<string, T> func, string request)
    {
        try
        {
            Console.WriteLine(func(request));
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static void Main(string[] args)
    {
        var csvTable = new Table("df.csv");
        while (true)
        {
            switch (Console.ReadLine())
            {
                case "1":
                    ProcessRequest(csvTable.FindAnnualFeatureValueInRegion, Console.ReadLine());
                    break;
                case "2":
                    ProcessRequest(csvTable.FindAverageAnnualFeatureValueInRegion, Console.ReadLine());
                    break;
                case "3":
                    ProcessRequest(csvTable.FindRegionWithMonthlyMaxOrMinFeatureValue, Console.ReadLine());
                    break;
                case "4":
                    ProcessRequest(csvTable.FindMonthlyAverageFeatureValueInAllRegions, Console.ReadLine());
                    break;
                default:
                    return;
            } 
        }
    }
}
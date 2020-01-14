using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] lines = Console.ReadLine().Split(' ');
            CourseWork cw = null;
            if (lines[2] == "1")
                cw = new FirstYearCourseWork(lines[0], int.Parse(lines[1]));
            else
                cw = new SecondYearCourseWork(lines[0], int.Parse(lines[1]));
        }
        Console.WriteLine(CourseWork.GetHowManyPassed);
        Console.WriteLine(SecondYearCourseWork.GetMaximum());
    }
}


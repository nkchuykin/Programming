using System;

class Program
{

    static void Main(string[] args)
    {
        using (StudentReader studentReader = new StudentReader("students.txt"))
        {
            double averageGPA = GetAverageGPA(studentReader);
            foreach (var item in studentReader.GetStudentsWithGreaterGPA(averageGPA))
            {
                Console.WriteLine(item);
            }
        }
    }

    private static double GetAverageGPA(StudentReader studentReader)
    {
        double averageGPA = 0;
        int studentsCount = 0;

        foreach (var item in studentReader)
        {
            averageGPA += item.GPA;
            studentsCount += 1;
        }

        averageGPA /= studentsCount;
        return averageGPA;
    }
}
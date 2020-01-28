using System;
using System.IO;


class Program
{

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Student[] students = InputStudents(n);
        try
        {
            var sorted = Methods.Sort(students, Console.ReadLine());
            PrintResult(students, sorted);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }


    }

    private static void PrintResult(Student[] students, Student[] sorted)
    {
        Console.WriteLine("Before:");
        foreach (var item in students)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("After:");
        foreach (var item in sorted)
        {
            Console.WriteLine(item);
        }
    }

    private static Student[] InputStudents(int n)
    {
        Student[] students = new Student[n];
        for (int i = 0; i < n; i++)
        {
            students[i] = (Student)Console.ReadLine();
        }
        return students;
    }
}


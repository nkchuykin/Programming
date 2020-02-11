using System;
using System.Collections.Generic;

class Program
{

    static void Main(string[] args)
    {
        List<Teacher> teachersList = new List<Teacher>();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
            teachersList.AddRange(Teacher.CreateTeachersWorkingInOnePlace(Console.ReadLine(), Console.ReadLine().Split()));
        foreach (string teacherName in Teacher.FindColleaguesNames(Console.ReadLine(), teachersList.ToArray()))
            Console.Write(teacherName + " ");
    }

}

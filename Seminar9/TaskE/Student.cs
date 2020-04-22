using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Student
{
    string Surname;

    List<int> marks;

    public Student(string surname, List<int> marks)
    {
        Surname = surname;
        this.marks = marks;
    }

    public Student(string inputLine)
    {
        string[] input = inputLine.Split();
        Surname = input[0];
        string[] marksInput= new string[input.Length-1];
        Array.Copy(input, 1, marksInput, 0, marksInput.Length);
        this.marks = new List<int>(Array.ConvertAll(marksInput,int.Parse));
    }

    public double GPA
    {
        get {
            return marks.Average();
        }
    }

    public override string ToString()
    {
        return Surname + " " + string.Join(" ",marks);
    }
}


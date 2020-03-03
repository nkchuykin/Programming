using System;

internal struct Student: IComparable<Student>
{
    int id;
    int height;
    int math;
    int english;
    int PE;

    public Student(int id, int height, int math, int english, int PE)
    {
        this.id = id;
        this.height = height;
        this.math = math;
        this.english = english;
        this.PE = PE;
    }

    public int CompareTo(Student other)
    {
        throw new NotImplementedException();
    }

    internal static Student Parse(string v)
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        throw new NotImplementedException();
    }
}
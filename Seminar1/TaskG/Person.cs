using System;
using System.Collections.Generic;


public class Person
{

    public Int32 WorkingHours
    {
        get {
            throw new NotImplementedException();
        }
        set {
            throw new NotImplementedException();
        }
    }

    public Person(Int32 workingHours)
    {
        throw new NotImplementedException();
    }

    internal static int GetAverageMoney()
    {
        throw new NotImplementedException();
    }

    public Int32 GetMoney()
    {
        throw new NotImplementedException();
    }
}

public class Student : Person
{


    public Boolean HasBadMarks
    {
        get {
            throw new NotImplementedException();
        }
    }

    public Student(int workingHours, bool hasBadMarks) : base(workingHours)
    {
        throw new NotImplementedException();
    }


    internal static int GetStudentsAverageMoney()
    {
        throw new NotImplementedException();
    }
}


using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Student
{
    public DateTime Birthday { get; private set; }
    public int Math { get; private set; }
    public int English { get; private set; }
    public int PE { get; private set; }
    public string Name { get; private set; }

    public static explicit operator Student(string str)
    {
        string[] arr = str.Split(new char[] { '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        if (arr.Length != 5)
            throw new InvalidCastException("Incorrect string");
        return new Student(arr[0], DateTime.Parse(arr[1],CultureInfo.GetCultureInfo("ru-RU")), int.Parse(arr[2]), int.Parse(arr[3]), int.Parse(arr[4]));
    }

    public Student(string name, DateTime birthday, int math, int english, int pe)
    {
        this.Birthday = birthday;
        this.Math = math;
        this.English = english;
        this.PE = pe;
        Name = name;
    }

    public static void Sort(Student[] students, Comparison<Student> comparison)
    { 
        for (int i = 0; i < students.Length; i++)
        {
            for (int j = 0; j < students.Length - i - 1; j++)
            {
                if (comparison(students[j], students[j + 1]) == 1)
                    Swap(ref students[j], ref students[j + 1]);
            }
        }

    }

    private static void Swap(ref Student student1, ref Student student2)
    {
        Student temp = student1;
        student1 = student2;
        student2 = temp;
    }

    public override string ToString()
    {
        return String.Format("{0}\t{1:dd-MM-yyyy} {2:D2} {3:D2} {4:D2}", Name, Birthday, Math, English, PE);
    }
}


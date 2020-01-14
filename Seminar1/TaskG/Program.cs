using System;

class Program
{
    static void Main(string[] args)
    {

        int N = int.Parse(Console.ReadLine());


        for (int i = 0; i < N; i++)
        {
            try
            {
                string[] input = Console.ReadLine().Split();
                if (input.Length == 1)
                    new Person(int.Parse(input[0]));
                else
                    new Student(int.Parse(input[0]), bool.Parse(input[1]));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

        }
        try
        {
            Console.WriteLine(Person.GetAverageMoney());
            Console.WriteLine(Student.GetStudentsAverageMoney());
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine(e.Message);
        }


    }
}




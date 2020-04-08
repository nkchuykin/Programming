internal class Program
{
    public static void Main(string[] args)
    {
        var students = Deserializer.DeserializeStudents("input.bin");
        Analytics.WriteStudentsWithGPANoLessThanAverage(students, "output.txt", Analytics.FindGPA(students));
    }
}
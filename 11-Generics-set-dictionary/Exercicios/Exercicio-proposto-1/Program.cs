namespace Exercise;
using Exercise.Entities;

class Program
{
    static HashSet<Student> students = new();
    static void Main(string[] args)
    {

        Console.Write("How many Students for course A? ");
        int courseA = int.Parse(Console.ReadLine());
        AddStudents('A', courseA);
        Console.Write("How many Students for course B? ");
        int courseB = int.Parse(Console.ReadLine());
        AddStudents('B', courseB);
        Console.Write("How many Students for course C? ");
        int courseC = int.Parse(Console.ReadLine());
        AddStudents('C', courseC);

        Console.Write($"Total Students: {students.Count}");

    }

    static void AddStudents(char course, int counter)
    {
        for (int i = 0; i < counter; i++)
        {
            Console.WriteLine($"Write the id for the {i + 1}º student");
            int id = int.Parse(Console.ReadLine());
            students.Add(new(id, course));
        }
    }
}

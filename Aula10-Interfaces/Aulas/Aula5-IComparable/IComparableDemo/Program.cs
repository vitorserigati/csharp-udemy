namespace IComparableDemo;
using IComparableDemo.Entities;

class Program
{
    static void Main(string[] args)
    {
        string path = @"/home/vitor/dev/csharp/Aula10-Interfaces/Aulas/Aula5-IComparable/in.csv";

        try
        {
            using (StreamReader sr = File.OpenText(path))
            {
                List<Employee> list = new List<Employee>();
                while (!sr.EndOfStream)
                {
                    list.Add(new Employee(sr.ReadLine()));
                }

                list.Sort();
                foreach (Employee employee in list)
                {
                    Console.WriteLine(employee);
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine($"Something went wrong {e.Message}");
        }
    }
}

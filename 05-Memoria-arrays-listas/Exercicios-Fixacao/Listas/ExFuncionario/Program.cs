using ExFuncionarioLib;
using System.Globalization;

class Program
{

    static void Main(string[] args)
    {

        List<Funcionario> funcList = new List<Funcionario>();
        Console.WriteLine("How Many employees will be registered? ");
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Console.Write($"What's the Id of the {i + 1}º employee? ");
            int id = int.Parse(Console.ReadLine());
            Console.Write($"What's the name of the {i + 1}º employee? ");
            string name = Console.ReadLine();
            Console.Write($"What's the salary of the {i + 1}º employee? ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcList.Add(new Funcionario(id, name, salary));
        }
        Console.Write("Enter the employee id that will have salary increase: ");
        int idIncrease = int.Parse(Console.ReadLine());
        Console.Write("\nEnter the percentage: ");
        double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Funcionario func = funcList.Find(x => x._id == idIncrease);
        if (func != null)
        {
            func.IncreaseSalary(percent);
        }
        else
        {
            Console.WriteLine("This id does not exist!");
        }
        Console.WriteLine("Updated List of employees: ");
        foreach (Funcionario funcionario in funcList)
        {
            Console.WriteLine(funcionario.ToString());
        }
    }
}

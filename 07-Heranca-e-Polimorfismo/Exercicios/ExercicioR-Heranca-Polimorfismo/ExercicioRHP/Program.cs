using System.Globalization;
using ExercicioRHP.Entities;
namespace ExercicioRHP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quantos funcionários serão registrados: ");
            int qtt = int.Parse(Console.ReadLine());
            Employee[] employees = new Employee[qtt];

            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"Employee #{i + 1} data:");
                Console.Write("Outsourced? (y/n): ");
                string outsourced = Console.ReadLine().ToLower();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (outsourced == "y")
                {
                    Console.Write("Additional Charge: ");
                    double additional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employees[i] = new OutsourcedEmployee(name, hours, value, additional);
                }
                else
                {
                    employees[i] = new Employee(name, hours, value);
                }
            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");

            foreach (Employee employeed in employees)
            {
                Console.WriteLine(employeed.ToString());
            }
        }
    }
}

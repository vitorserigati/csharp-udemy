namespace ExercicioR
{
    using ExercicioR.Entities;
    using ExercicioR.Entities.Enum;
    using System.Globalization;
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string dpName = Console.ReadLine();
            Department dp = new Department(dpName);

            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Worker level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Worker worker = new Worker(name, level, baseSalary, dp);

            Console.Write("How many contracts to this worker?: ");
            int contracts = int.Parse(Console.ReadLine());
            for (int i = 0; i < contracts; i++)
            {
                Console.WriteLine($"Enter #{i + 1} contract data: ");
                Console.Write("Date (DD/MM/YYYY):");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double val = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hour = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, val, hour);
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthYear = Console.ReadLine();
            int month = int.Parse(monthYear.Substring(0, 2));
            int year = int.Parse(monthYear.Substring(3));
            Console.WriteLine($"Name: {worker.Name}\nDepartment: {worker.Department.Name}");
            Console.Write($"Income for {month}/{year}: " +
                    worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

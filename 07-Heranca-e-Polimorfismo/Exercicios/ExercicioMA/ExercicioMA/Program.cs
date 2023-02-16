namespace ExercicioMA;

using ExercicioMA.Entities;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of tax payers: ");
        int payersAmt = int.Parse(Console.ReadLine());
        List<Person> payers = new List<Person>();

        for (int i = 0; i < payersAmt; i++)
        {
            Console.WriteLine($"Tax payer #{i + 1} data: ");
            Console.Write("Individual or Company (i/c)? ");
            char type = char.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Annual Income: ");
            double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            switch (type)
            {
                case 'c':
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    payers.Add(new LegalPerson(name, annualIncome, employees));
                    break;
                case 'i':
                    Console.Write("Health expenditures: ");
                    double healthE = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    payers.Add(new NaturalPerson(name, annualIncome, healthE));
                    break;
                default:
                    Console.Write("Unknown Option", nameof(type));
                    break;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Taxes Paid: ");
        double total = 0;

        foreach (Person payer in payers)
        {
            Console.WriteLine($"{payer.Name}: $ {payer.CalculateTax().ToString("F2", CultureInfo.InvariantCulture)}");
            total += payer.CalculateTax();
        }

        Console.WriteLine($"Total Taxes: $ {total.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}

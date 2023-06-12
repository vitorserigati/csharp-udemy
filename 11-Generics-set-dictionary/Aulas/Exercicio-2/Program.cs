namespace Course;
using System.Globalization;
using Course.Services;
using Course.Entities;

class Program
{
    public static void Main(string[] args)
    {
        List<Product> list = new List<Product>();

        Console.WriteLine("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Write the {i + 1}º item: ");
            string[] input = Console.ReadLine().Split(", ");
            string name = input[0];
            double price = double.Parse(input[1], CultureInfo.InvariantCulture);
            list.Add(new Product(name, price));
        }

        CalculationService calculationService = new CalculationService();

        Product max = calculationService.Max(list);

        Console.WriteLine("Max: ");
        Console.WriteLine(max);

    }
}

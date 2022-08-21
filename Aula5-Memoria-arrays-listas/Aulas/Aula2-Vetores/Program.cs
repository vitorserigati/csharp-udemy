using System.Globalization;

namespace Aula2_Vetores;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Products[] prod = new Products[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Digite o nome do produto: ");
            string name = Console.ReadLine();
            Console.Write("Digite o valor do produto: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            prod[i] = new Products(name, price);
        }

        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += prod[i].Price;
        }

        double avg = sum / n;

        Console.WriteLine($"Average Price = {avg.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}
using System.Globalization;
using ExercicioProHP.Entities;
namespace ExercicioProHP
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the number of products: ");
            int number = int.Parse(Console.ReadLine());
            List<Product> products = new List<Product>();
            for (int i = 0; i < number; i++)
            {
                Console.Write("Product #{0} data: ", (i+1));
                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                switch (type)
                {
                    case 'c':
                        products.Add(new Product(name, price));
                        break;
                    case 'i':
                        Console.Write("Customs fee: ");
                        double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        products.Add(new ImportedProduct(name, price, fee));
                        break;
                    case 'u':
                        Console.Write("Manufacture Date (DD/MM/YYYY): ");
                        string date = Console.ReadLine();
                        products.Add(new UsedProduct(name, price, date));
                        break;
                    default:
                        Console.WriteLine("Unknown Option. Closing Program");
                        break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach(Product prod in products)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}



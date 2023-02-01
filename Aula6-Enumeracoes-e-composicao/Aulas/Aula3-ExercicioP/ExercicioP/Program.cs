using ExercicioP.Entities;
using ExercicioP.Entities.Enum;
using System.Globalization;
namespace ExercicioP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("E-mail: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            string birth = Console.ReadLine();
            Client client = new Client(name, email, birth);

            Console.WriteLine("Enter the Order Data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(status, client);

            Console.Write("How many items to this order?: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i + 1} item data: ");
                Console.Write("Item Name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem item = new OrderItem(quantity, price, productName);
                order.AddItem(item);

            }

            Console.WriteLine(order.ToString());
        }
    }
}

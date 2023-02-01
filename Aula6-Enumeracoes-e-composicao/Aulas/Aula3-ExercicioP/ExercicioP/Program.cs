using ExercicioP.Entities;
using ExercicioP.Entities.Enum;
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
            OrderItem status = Enum.Parse<OrderItem>(Console.ReadLine());

        }
    }
}

namespace Course;
class Program
{

    public static void Main(string[] args)
    {
        PrintService service = new PrintService();

        Console.WriteLine("How many values?");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Write the {i + 1}º number");
            int x = int.Parse(Console.ReadLine());
            service.AddValue(x);
        }

        service.Print();
        Console.WriteLine($"First: {service.First()}");
    }

}

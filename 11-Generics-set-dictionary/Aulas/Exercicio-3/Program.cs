namespace Course;
using Course.Entities;

class Program{
    
    public static void Main(string[] args)
    {
        Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
        Client b = new Client { Name = "Alex", Email = "alex@gmail.com" };

        Console.WriteLine(a.Equals(b));

        System.Console.WriteLine(a.GetHashCode());
        System.Console.WriteLine(b.GetHashCode());
        System.Console.WriteLine(a == b);
    }
}


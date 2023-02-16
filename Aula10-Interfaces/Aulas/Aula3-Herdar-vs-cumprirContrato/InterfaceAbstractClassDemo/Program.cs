namespace InterfaceClassAbstractDemo;
using InterfaceClassAbstractDemo.Model.Entities;
using InterfaceClassAbstractDemo.Model.Enums;

class Program
{
    static void Main(string[] args)
    {
        AbstractShape s1 = new Circle() { Radius = 2.0, Color = Color.White };
        AbstractShape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.Black };

        Console.WriteLine(s1);
        Console.WriteLine(s2);
    }
}


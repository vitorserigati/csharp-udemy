using System.Globalization;
namespace csharp;
class Program
{
    static void Main()
    {

        Triangulo x = new Triangulo();
        Triangulo y = new Triangulo();
        Console.WriteLine("Entre com as Medidas do triângulo X:");
        x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Entre com as medidas do triângulo Y");

        y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);




        Console.WriteLine("Área de X = " + x.Area().ToString("f4", CultureInfo.InvariantCulture));
        Console.WriteLine("Área de Y = " + y.Area().ToString("f4", CultureInfo.InvariantCulture));

        if (x.Area() > y.Area())
        {
            Console.WriteLine("Maior Área: X");
        }
        else
        {
            Console.WriteLine("Maior Área: Y");
        }
    }
}
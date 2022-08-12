using System.Globalization;
namespace Aula2;

class Program
{
    static void Main()
    {
        Triangulo a = new Triangulo();
        Triangulo b = new Triangulo();
        Console.WriteLine("Digite o valor do lado A do triângulo 1: ");
        a.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Digite o valor do lado B do triângulo 1: ");
        a.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Digite o valor do lado C do triângulo 1: ");
        a.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Digite o valor do lado A do triângulo 2: ");
        b.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Digite o valor do lado B do triângulo 2: ");
        b.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Digite o valor do lado C do triângulo 2: ");
        b.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double areaA = a.Area();
        double areaB = b.Area();

        Console.WriteLine($"A área do triângulo A é: {areaA.ToString("F4", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"A área do triângulo B é: {areaB.ToString("F4", CultureInfo.InvariantCulture)}");
    }

}
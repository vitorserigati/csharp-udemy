using System.Globalization;

namespace Exercicio_fixacao;

class Program
{

    static void Main()
    {
        Retangulo r = new Retangulo();

        Console.WriteLine("Entre a largura e altura do retângulo: ");
        r.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        r.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine(r);
    }
}
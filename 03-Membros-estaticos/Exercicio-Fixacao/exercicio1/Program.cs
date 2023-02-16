using System.Globalization;

namespace Exercicio1;

class Program
{
    static void Main()
    {
        Console.Write("Qual é a cotação do dolar? ");
        double cot = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Quantos dólares você vai comprar? ");
        double qnt = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double dolar = ConversorDeMoeda.Conversao(qnt, cot);

        Console.WriteLine($"Valor a ser pago em reais = {dolar.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}
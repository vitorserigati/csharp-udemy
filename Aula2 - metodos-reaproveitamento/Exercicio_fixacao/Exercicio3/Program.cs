using System.Globalization;

namespace Exercicio3;

class Program
{
    static void Main()
    {

        Aluno aluno = new Aluno();
        Console.Write("Nome do Aluno: ");
        aluno.Nome = Console.ReadLine();
        Console.WriteLine("Digite as três notas do aluno: ");
        aluno.NotaA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        aluno.NotaB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        aluno.NotaC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine(aluno);
    }
}
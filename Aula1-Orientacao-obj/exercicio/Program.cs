using exercicio.classes;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa pessoaA = new Pessoa();
        Pessoa pessoaB = new Pessoa();

        Console.WriteLine("Digite o Nome da primeira Pessoa: ");
        pessoaA.Name = Console.ReadLine();
        Console.WriteLine("Digite a idade da primeira Pessoa: ");
        pessoaA.Age = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o Nome da segunda Pessoa: ");
        pessoaB.Name = Console.ReadLine();
        Console.WriteLine("Digite a idade da segunda Pessoa: ");
        pessoaB.Age = int.Parse(Console.ReadLine());

        if (pessoaA.Age > pessoaB.Age)
        {
            Console.WriteLine("A pessoa mais velha é: " + pessoaA.Name);
        }
        else
        {
            Console.WriteLine("A pessoa mais velha é: " + pessoaB.Name);
        }


        Funcionario A = new Funcionario();
        Funcionario B = new Funcionario();

        Console.WriteLine("Digite o nome do primeiro funcionário: ");
        A.Name = Console.ReadLine();
        Console.WriteLine("Digite o salário do primeiro funcionário: ");
        A.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Digite o nome do Segundo funcionário: ");
        B.Name = Console.ReadLine();
        Console.WriteLine("Digite o salário do Segundo funcionário: ");
        B.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double media = (A.Salario + B.Salario) / 2;

        Console.WriteLine("A média do salário entre " + A.Name + " e " + B.Name + " é: " + media.ToString("f2"));
    }
}
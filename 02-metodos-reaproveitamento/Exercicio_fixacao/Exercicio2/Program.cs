using System.Globalization;
namespace Exercicio2;
class Program
{
    static void Main()
    {
        Funcionario func = new Funcionario();

        Console.WriteLine("Digite o Nome do funcionário: ");
        func.Name = Console.ReadLine();
        Console.WriteLine("Digite o salário bruto do Funcionário: ");
        func.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Digite o imposto sobre o salário do funcionário: ");
        func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine($"Funcionário: {func}");
        Console.Write("Digite a porcentagem para aumentar o salário: ");
        func.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

        Console.WriteLine($"Dados Atualizados: {func}");
    }
}
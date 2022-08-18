using System.Globalization;
namespace Exercicio_Produto;

class Program
{
    static void Main()
    {
        Produto prod = new Produto();
        Console.WriteLine("Entre com os dados do produto: ");
        Console.WriteLine("Nome: ");
        prod.Name = Console.ReadLine();
        Console.WriteLine("Preço: ");
        prod.Valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Quandidade em estoque: ");
        prod.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine($"Dados do Produto: {prod}");
        Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
        prod.AdicionarItens(int.Parse(Console.ReadLine()));
        Console.WriteLine($"Dados Atualizados: {prod}");
        Console.WriteLine("Digite o número de produtos a ser retirado do estoque: ");
        prod.RemoverItens(int.Parse(Console.ReadLine()));
        Console.WriteLine($"Dados Atualizados: {prod}");

    }

}

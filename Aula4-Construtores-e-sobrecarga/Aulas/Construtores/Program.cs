using System.Globalization;

namespace Construtores;

class Program
{
    static void Main()
    {
        Console.WriteLine("Entre os dados do produto: ");

        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Quantidade no estoque: ");
        int quantidade = int.Parse(Console.ReadLine());
        Produto prod = new Produto(nome, preco, quantidade);
        Console.WriteLine($"Dados do produto: {prod}");
        Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
        prod.Adicionar(int.Parse(Console.ReadLine()));
        Console.WriteLine($"Dados atualizados: {prod}");

        Console.Write("Digite o número de produtos a ser removido do estoque: ");
        prod.Remover(int.Parse(Console.ReadLine()));
        Console.WriteLine($"Dados atualizados: {prod}");

    }
}
using System.Globalization;
namespace Exercicio_Produto;

public class Produto
{
    public string Name;
    public double Valor;
    public int Quantidade;

    public double valorTotalEmEstoque()
    {
        return Valor * Quantidade;
    }
    public void AdicionarItens(int Qnt)
    {
        Quantidade += Qnt;
    }
    public void RemoverItens(int Qnt)
    {
        Quantidade -= Qnt;
    }

    public override string ToString()
    {
        return $"{Name}, ${Valor.ToString("F2", CultureInfo.InvariantCulture)}, {Quantidade} itens em estoque:";

    }
}

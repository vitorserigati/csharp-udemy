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
}

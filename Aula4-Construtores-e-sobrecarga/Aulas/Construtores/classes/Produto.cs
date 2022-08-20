using System.Globalization;

namespace Construtores;

public class Produto
{
    private string _nome;
    public double Preco { get; private set; } //auto prop
    public int Quantidade { get; private set; }
    public Produto(string nome, double preco)
    {
        _nome = nome;
        Preco = preco;
        Quantidade = 0;
    }
    public Produto(string nome, double preco, int qnt) : this(nome, preco)
    {
        if (qnt < 0)
        {
            Quantidade = 0;
        }
        Quantidade = qnt;
    }

    //Prop
    public string Nome
    {
        get { return _nome; }
        set
        {
            if (value != null && value.Length > 1)
            {
                _nome = value;
            }
        }
    }

    /*
        Encapsulamento manual 

        public string GetNome()
        {
            return _nome;
        }
        public void SetNome(string nome)
        {
            _nome = nome;
        }
        public double GetPreco()
        {
            return _preco;
        }

        public int GetQnt()
        {
            return _quantidade;
        }*/

    public void Adicionar(int qnt)
    {
        Quantidade += qnt;
    }
    public void Remover(int qnt)
    {
        Quantidade -= qnt;
    }
    public double Valor()
    {
        return Quantidade * Preco;
    }

    public override string ToString()
    {
        return $"{_nome}, ${Preco.ToString("F2", CultureInfo.InvariantCulture)}, {Quantidade} unidades, Total: ${Valor().ToString("F2", CultureInfo.InvariantCulture)}";
    }
}

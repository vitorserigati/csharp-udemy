
namespace Exerciciof_Conta;

public class Conta
{
    public int Numero { get; private set; }
    public string Nome { get; set; }

    private double _saldo;

    public Conta(int numero, string nome)
    {
        Numero = numero;
        Nome = nome;
        _saldo = 0.0;
    }

    public Conta(int numero, string nome, double saldo) : this(numero, nome)
    {
        _saldo = saldo;
    }
}

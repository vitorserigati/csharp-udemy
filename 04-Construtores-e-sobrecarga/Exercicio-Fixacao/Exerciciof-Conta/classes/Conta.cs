
using System.Globalization;

namespace Exerciciof_Conta;

public class Conta
{
    private double Taxa = 5.0;
    public int Numero { get; private set; }
    private string _nome;

    public double Saldo { get; private set; }

    public Conta(int numero, string nome)
    {
        Numero = numero;
        if (nome != null && nome.Length > 1)
        {
            _nome = nome;

        }
    }

    public Conta(int numero, string nome, double depInicial) : this(numero, nome)
    {
        Deposito(depInicial);
    }
    public string Nome
    {
        get => _nome;
        set
        {
            if (value != null && value.Length > 1)
            {
                _nome = value;
            }
        }
    }



    public void Deposito(double valor)
    {
        if (valor > 0)
            Saldo += valor;
    }
    public void Saque(double valor)
    {
        if (valor > 0)
            Saldo -= valor + Taxa;
    }

    public override string ToString()
    {
        return $"Conta: {Numero}, Titular: {_nome}, Saldo: ${Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
    }
}

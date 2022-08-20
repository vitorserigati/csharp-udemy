using System.Globalization;

namespace Exerciciof_Conta;

class Program
{
    static void Main()
    {
        Conta conta;
        double valor;
        Console.Write("Entre o número da conta: ");
        int numero = int.Parse(Console.ReadLine());
        Console.Write("Entre o titular da conta: ");
        string titular = Console.ReadLine();
        Console.Write("Haverá depósito inicial? (s/n)?");
        var resp = Console.ReadLine();

        if (resp == "s" || resp == "S")
        {
            Console.Write("Entre o valor de depósito inicial: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta = new Conta(numero, titular, valor);
        }
        else
        {
            conta = new Conta(numero, titular);
        }
        Console.WriteLine("Dados da conta:");
        Console.WriteLine(conta);

        Console.Write("\nEntre um valor para o depósito: ");
        valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta.Deposito(valor);
        Console.WriteLine("Dados da conta:");
        Console.WriteLine(conta);

        Console.Write("\nEntre um valor para saque: ");
        valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta.Saque(valor);
        Console.WriteLine("Dados da conta:");
        Console.WriteLine(conta);
    }
}
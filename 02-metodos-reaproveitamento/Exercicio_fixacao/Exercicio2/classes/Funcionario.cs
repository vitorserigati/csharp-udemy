using System.Globalization;
namespace Exercicio2;

public class Funcionario
{
    public string Name;
    public double Salario;
    public double Imposto;

    public double SalarioLiquido()
    {
        return Salario - Imposto;
    }

    public void AumentarSalario(double percent)
    {
        Salario += Salario * (percent / 100);
    }

    public override string ToString()
    {
        return $"{Name}, ${SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}";
    }
}

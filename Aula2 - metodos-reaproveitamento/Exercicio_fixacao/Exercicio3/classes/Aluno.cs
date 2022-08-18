using System.Globalization;
namespace Exercicio3;

public class Aluno
{
    public string Nome;
    public double NotaA;
    public double NotaB;
    public double NotaC;

    private double resultado()
    {
        return NotaA + NotaB + NotaC;
    }
    public override string ToString()
    {
        if (resultado() < 60.00)
        {
            return $"Nota Final = {resultado().ToString("F2", CultureInfo.InvariantCulture)}"
            + "\nReprovado "
            + $"Faltaram {(60.00 - resultado()).ToString("F2", CultureInfo.InvariantCulture)} Pontos";
        }
        else
        {
            return $"Nota Final = {resultado().ToString("F2", CultureInfo.InvariantCulture)}"
            + "\nAprovado";
        };
    }

}

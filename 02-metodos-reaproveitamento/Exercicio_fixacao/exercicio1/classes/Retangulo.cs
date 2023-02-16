using System.Globalization;

namespace Exercicio_fixacao;

public class Retangulo
{
    public double A;
    public double B;

    public double Area()
    {
        return A * B;
    }

    public double Perimetro()
    {
        return (A + B) * 2;
    }

    public double Diagonal()
    {
        double d = Math.Sqrt((B * B) + (A * A));
        return d;
    }

    public override string ToString()
    {
        return $"Area = {Area().ToString("F2", CultureInfo.InvariantCulture)}\n"
        + $"Perímetro = {Perimetro().ToString("F2", CultureInfo.InvariantCulture)}\n"
        + $"Diagonal = {Diagonal().ToString("F2", CultureInfo.InvariantCulture)}";

    }
}

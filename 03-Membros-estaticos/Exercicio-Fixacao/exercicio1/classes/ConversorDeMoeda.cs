namespace Exercicio1;

public class ConversorDeMoeda
{
    public static double Iof = 0.06;

    public static double Conversao(double qnt, double cot)
    {

        double dolar = qnt * cot;
        return dolar += dolar * Iof;
    }
}

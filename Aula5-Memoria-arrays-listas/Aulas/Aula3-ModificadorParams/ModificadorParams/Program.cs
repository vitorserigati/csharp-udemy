namespace ModificadorParams
{
    using ModificadorParamsLib;

    class Program
    {
        static void Main(string[] args)
        {
           int soma = Calculator.Sum(1, 2, 3, 4);
           Console.WriteLine(soma);
        }
    }
}

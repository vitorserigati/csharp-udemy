namespace RefOut
{
    using RefOutLib;
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b;
            Calculator.Triple(ref a);
            Console.WriteLine(a);
            Calculator.SqrIt(10, out b);
            Console.WriteLine(b);
        }
    }
}

namespace RefOutLib;
public class Calculator
{
    public static void Triple(ref int x)
    {
        x = x * 3;
    }
    public static void SqrIt(int original, out int x)
    {
        x = original * 2;
    }

}

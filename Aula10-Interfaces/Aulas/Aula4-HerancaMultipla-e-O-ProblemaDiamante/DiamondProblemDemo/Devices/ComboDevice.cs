namespace DiamondProblemDemo.Devices;

//public class ComboDevice : Scanner, Printer  | Compiler error. Não é possível herdar de duas classes ao mesmo tempo!
public class ComboDevice : Device, IScanner, IPrinter // Herdando uma classe (Device) e implementando as funções de duas interfaces.
{
    public void Print(string document)
    {
        Console.WriteLine($"ComboDevice print {document}");
    }

    public override void ProcessDoc(string document)
    {
        Console.WriteLine($"ComboDevice ProcessDoc {document}");
    }

    public string Scan()
    {
        return "ComboDevice Scan Result";
    }
}


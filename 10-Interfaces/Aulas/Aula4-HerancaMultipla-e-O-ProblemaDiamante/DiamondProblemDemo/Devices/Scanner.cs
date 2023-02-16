namespace DiamondProblemDemo.Devices;

public class Scanner : Device, IScanner
{
    public override void ProcessDoc(string document)
    {
        Console.WriteLine($"Scannner Processing {document}");
    }
    public string Scan()
    {
        return "Scanner scan result";
    }
}


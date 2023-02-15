namespace InterfaceExercise;
using InterfaceExerciseLibrary.Entities;
using InterfaceExerciseLibrary.Services;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter contract data");
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Date (dd/mm/yyyy): ");
        DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
        Console.Write("Contract value: ");
        decimal value = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Contract contract = new Contract(number, date, value);

        Console.Write("Enter number of installments: ");
        int installments = int.Parse(Console.ReadLine());
        InstallService install = new InstallService(installments, new PayPalService());
        install.ProcessInstall(contract);
        Console.WriteLine();
        Console.WriteLine("Installments:");
        Console.WriteLine(contract.ToString());
    }
}

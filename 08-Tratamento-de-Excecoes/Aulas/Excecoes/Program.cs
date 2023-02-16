namespace Excecoes;
using ExcecoesLibrary.Entities;
using ExcecoesLibrary.Entities.Exceptions;
public class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Room Number: ");
            Console.ForegroundColor = ConsoleColor.Green;
            int rNumber = int.Parse(Console.ReadLine());
            Console.ResetColor();

            Console.Write("Check-in date (dd/MM/yyyy): ");
            Console.ForegroundColor = ConsoleColor.Green;
            DateTime checkin = DateTime.Parse(Console.ReadLine());
            Console.ResetColor();

            Console.Write("Check-Out date (dd/MM/yyyy): ");
            Console.ForegroundColor = ConsoleColor.Green;
            DateTime checkout = DateTime.Parse(Console.ReadLine());
            Console.ResetColor();

            Reservation reservation = new(rNumber, checkin, checkout);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Reservation: {reservation}");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Enter data to update reservation: ");
            Console.Write("Check-in date (dd/MM/yyyy): ");
            Console.ForegroundColor = ConsoleColor.Green;
            checkin = DateTime.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.Write("Check-out date (dd/MM/yyyy): ");
            Console.ForegroundColor = ConsoleColor.Green;
            checkout = DateTime.Parse(Console.ReadLine());
            Console.ResetColor();

            reservation.UpdateDates(checkin, checkout);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Reservation: {reservation}");
            Console.ResetColor();

        }
        catch (DomainException e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error in reservation: " + e.Message);
            Console.ResetColor();
        }
        catch (FormatException e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Format error: {e.Message}");
            Console.ResetColor();
        }



    }
}

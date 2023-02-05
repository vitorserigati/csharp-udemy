namespace EExceptions;
using System.Globalization;
using EExceptionsLibrary.Entities;
using EExceptionsLibrary.Entities.Exceptions;

public class Program
{
    public static void Main(string[] args)

    {
        try
        {
            Console.WriteLine("Enter account data: ");
            Console.Write("Number: ");
            Console.ForegroundColor = ConsoleColor.Green;
            int number = int.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.Write("Holder: ");

            Console.ForegroundColor = ConsoleColor.Green;
            string holder = Console.ReadLine();
            Console.ResetColor();

            Console.Write("Initial Balance: ");
            Console.ForegroundColor = ConsoleColor.Green;
            decimal balance = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.ResetColor();


            Console.Write("Withdraw Limit: ");
            Console.ForegroundColor = ConsoleColor.Green;
            decimal withdrawLimit = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.ResetColor();

            Account account = new(number, holder, balance, withdrawLimit);


            Console.Write("Enter amount for withdraw: ");
            Console.ForegroundColor = ConsoleColor.Green;
            decimal ammount = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.ResetColor();

            account.Withdraw(ammount);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"New balance: {account.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        catch (OutOfBalanceException e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Withdraw error: {e.Message}");
            Console.ResetColor();
        }
        catch (WithdrawLimitExceededException e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Withdraw error: {e.Message}");
            Console.ResetColor();

        }
        catch (FormatException e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Wrong input: {e.Message}");
            Console.ResetColor();
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Constructor error: {e.Message}");
            Console.ResetColor();
        }
    }
}

namespace InterfaceExerciseLibrary.Entities;
using System.Globalization;
public class Installment
{
    public DateTime Date { get; set; }
    public decimal Amount { get; set; }

    public Installment(DateTime date, decimal amount)
    {
        Date = date;
        Amount = amount;
    }

    public override string ToString()
    {
        return $"{Date.ToShortDateString()} - {Amount.ToString("F2", CultureInfo.InvariantCulture)}";
    }
}

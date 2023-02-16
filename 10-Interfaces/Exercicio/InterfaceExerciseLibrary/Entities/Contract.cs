namespace InterfaceExerciseLibrary.Entities;

public class Contract
{
    public int Number { get; private set; }
    public DateTime Date { get; private set; }
    public decimal TotalValue { get; private set; }
    public List<Installment> Installments { get; private set; } = new List<Installment>();

    public Contract(int number, DateTime date, decimal totalValue)
    {
        Number = number;
        Date = date;
        TotalValue = totalValue;
    }

    public void AddInstallment(Installment installment)
    {
        Installments.Add(installment);
    }


    public override string ToString()
    {
        StringWriter sw = new StringWriter();

        foreach (Installment installment in Installments)
        {
            sw.WriteLine(installment);
        }
        return sw.ToString();
    }
}

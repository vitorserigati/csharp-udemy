namespace NoInterfaceDemo.Entities;
using System.Globalization;
public class Invoice
{
    public double BasicPayment { get; set; }
    public double Tax { get; set; }

    public Invoice(double basicPayment, double tax)
    {
        BasicPayment = basicPayment;
        Tax = tax;
    }
    public double TotalPayment
    {
        get { return BasicPayment + Tax; }
    }

    public override string ToString()
    {
        StringWriter sw = new StringWriter();
        sw.Write("Basic Payment: ");
        sw.WriteLine(BasicPayment.ToString("F2", CultureInfo.InvariantCulture));
        sw.Write("Tax: ");
        sw.WriteLine(Tax.ToString("F2", CultureInfo.InvariantCulture));
        sw.Write("Total Payment: ");
        sw.WriteLine(TotalPayment.ToString("F2", CultureInfo.InvariantCulture));
        return sw.ToString();
    }
}

namespace FileExcerciseDemo.Entities;
using System.Globalization;
public sealed class Product
{
    public string Name { get; private set; }
    public decimal Value { get; private set; }
    public int Quantity { get; private set; }
    public decimal TotalSold { get; private set; } = 0M;
    public Product(string[] productInfo)
    {
        Name = productInfo[0];
        Value = decimal.Parse(productInfo[1], CultureInfo.InvariantCulture);
        Quantity = int.Parse(productInfo[2]);
    }

    private void CalculateTotal()
    {
        TotalSold = Value * Quantity;
    }

    public override string ToString()
    {
        CalculateTotal();
        return $"{Name},{TotalSold.ToString("F2", CultureInfo.InvariantCulture)}";
    }

}



namespace Course.Entities;
using System.Globalization;

class Product : IComparable
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return Name
            + ", "
            + Price.ToString("F2", CultureInfo.InvariantCulture);
    }

    public int CompareTo(object? other)
    {
        if (!(other is Product)) throw new ArgumentException("Comparing error: argument is not a Product");

        Product? prod = other as Product;

        return Price.CompareTo(prod.Price);
    }
}
